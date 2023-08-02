using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Crafting_System.Gear;

namespace Crafting_System
{

    public class ItemCreationService
    {
        private Random random = new Random();
        private Dictionary<Rarity, int> rarityWeight = new Dictionary<Rarity, int>();

        int NORMAL_RARITY_WEIGHT = 600;
        int MAGIC_RARITY_WEIGHT = 250;
        int RARE_RARITY_WEIGHT = 100;
        int EPIC_RARITY_WEIGHT = 40;
        int LEGENDARY_RARITY_WEIGHT = 7;
        int SUPER_RARITY_WEIGHT = 3;

        public ItemCreationService()
        {
            new Head().PopulateGear(random);
            new Chest().PopulateGear(random);
            rarityWeight.Add(Rarity.Normal, NORMAL_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Magic, MAGIC_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Rare, RARE_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Epic, EPIC_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Legendary, LEGENDARY_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Super, SUPER_RARITY_WEIGHT);
        }

        public AffixValue GetAffixValue(Affix affix, int level)
        {
            switch (affix)
            {
                case Affix.Prefix_AllSkills: return new AffixCreator().RollAllSkills(level);
                case Affix.Prefix_Armor: return new AffixCreator().RollArmor(level);
                case Affix.Prefix_AttackSpeed: return new AffixCreator().RollAttackSpeed(level);
                case Affix.Prefix_CooldownReduction: return new AffixCreator().RollCooldownReduction(level);
                case Affix.Prefix_CritChance: return new AffixCreator().RollCritChance(level);
                case Affix.Prefix_CritDamage: return new AffixCreator().RollCritDamage(level);
                case Affix.Prefix_ColdDamage: return new AffixCreator().RollDamageIncrease(level);
                case Affix.Prefix_FireDamage: return new AffixCreator().RollDamageIncrease(level);
                case Affix.Prefix_LightningDamage: return new AffixCreator().RollDamageIncrease(level);
                case Affix.Prefix_Life: return new AffixCreator().RollLife(level);
                case Affix.Prefix_Dexterity: return new AffixCreator().RollBaseStat(level);
                case Affix.Suffix_DodgeChance: return new AffixCreator().RollDodgeChance(level);
                case Affix.Suffix_GoldFind: return new AffixCreator().RollGoldFind(level);
                case Affix.Suffix_HealthRegen: return new AffixCreator().RollHealthRegen(level);
                case Affix.Prefix_Intelligence: return new AffixCreator().RollBaseStat(level);
                case Affix.Suffix_MagicFind: return new AffixCreator().RollMagicFind(level);
                case Affix.Suffix_MovementSpeed: return new AffixCreator().RollMovementSpeed(level);
                case Affix.Suffix_Projectiles: return new AffixCreator().RollProjectiles(level);
                case Affix.Suffix_SpellRadius: return new AffixCreator().RollSpellRadius(level);
                case Affix.Prefix_Strength: return new AffixCreator().RollBaseStat(level);
                default: return new AffixValue(1,1,random);
            }
        }

        public int GetBucket(int level)
        {
            int value = level switch
            {
                int i when i < 13 => 1,
                int i when i >= 13 && i < 26 => 2,
                int i when i >= 26 && i < 39 => 3,
                int i when i >= 39 && i < 55 => 4,
                int i when i >= 55 => 5,
                _ => 1,
            };

            return value;
        }

        private EquipmentItem GetNonLegendaryEquipmentItem(EquipmentItem item, int level, int maxBucket)
        {
            BaseItem basePiece = new BaseItem();
            switch (item.Slot)
            {
                case GearSlot.Head:
                    basePiece = new Head().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Chest:
                    basePiece = new Chest().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
            }
            item.Name = basePiece.Name;
            item.BaseAffixes = basePiece.Affixes;
            item.Armor = basePiece.Armor ?? null;
            item.AttackDamage = basePiece.AttackDamge ?? null;
            item.RequiredLevel = basePiece.RequiredLevel;

            return item;
        }

        private EquipmentItem GetLegendaryEquipmentItem(EquipmentItem item, int level, int maxBucket)
        {
            var legendaryItems = new List<EquipmentItem>();
            switch (item.Slot)
            {
                case GearSlot.Head:
                    legendaryItems = new Head().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Chest:
                    legendaryItems = new Chest().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
            }

            if (legendaryItems.Any())
            {
                var legendaryRoll = random.Next(legendaryItems.Count);
                item = legendaryItems[legendaryRoll];
            } else
            {
                item.Rarity = Rarity.Epic;
                item = GetNonLegendaryEquipmentItem(item, level, maxBucket);
            }

            return item;
        }

        public EquipmentItem CreateEquipmentItem(int level, GearSlot slot)
        {
            EquipmentItem item = new EquipmentItem();
            item.Rarity = RollRarity(level);

            if(slot == GearSlot.Head || slot == GearSlot.Chest)
            {
                int maxBucket = GetBucket(level);

                if (item.Rarity == Rarity.Legendary)
                {
                    item = GetLegendaryEquipmentItem(item, level, maxBucket);

                } else
                {
                    item = GetNonLegendaryEquipmentItem(item, level, maxBucket);
                }
            } 
            else
            {
                item.Name = item.Rarity.ToString();
            }
            
            item.Slot = slot;


            List<ItemAffix> prefixes = RollAffixes(slot, AffixType.Prefix);
            List<ItemAffix> suffixes = RollAffixes(slot, AffixType.Suffix);

            int remainingAffixes = item.MaxAffix;

            while (remainingAffixes > 0)
            {
                bool canAddPrefix = item.Prefixes.Count < 3;
                bool canAddSuffix = item.Suffixes.Count < 3;

                if (!canAddPrefix && !canAddSuffix)
                {
                    // No more affixes available for both prefixes and suffixes
                    break;
                }

                if (canAddPrefix && random.Next(0, 2) == 0)
                {
                    ItemAffix affix = CreateAffix(prefixes);
                    while(item.Prefixes.Contains(affix))
                    {
                        affix = CreateAffix(prefixes);
                    }

                    affix.Values = GetAffixValue(affix.Affix, level);
                    item.AddAffix(affix, AffixType.Prefix);

                    remainingAffixes--;
                }
                else if (canAddSuffix)
                {
                    ItemAffix affix = CreateAffix(suffixes);
                    while (item.Suffixes.Contains(affix))
                    {
                        affix = CreateAffix(suffixes);
                    }
                    affix.Values = GetAffixValue(affix.Affix, level);

                    item.AddAffix(affix, AffixType.Suffix);
                    remainingAffixes--;
                }
            }

            // Calculate and apply the stat modifiers based on the affixes

            return item;
        }

        private ItemAffix CreateAffix(List<ItemAffix> affixes)
        {
            return affixes[random.Next(0, affixes.Count)];
        }

        private List<ItemAffix> RollAffixes(GearSlot slot, AffixType affixType)
        {
            Dictionary<GearSlot, List<ItemAffix>> affixPools = affixType == AffixType.Prefix
                ? GearService.GetSlotPrefixes()
                : GearService.GetSlotSuffixes();

            List<ItemAffix> affixes = affixPools[slot];
            // Perform random selection or any additional logic you need here

            return affixes;
        }

        private Rarity RollRarity(int level)
        {
            UpdateRarityWeights(level);
            int weight = rarityWeight.Sum(x => x.Value);
            int roll = random.Next(1, weight);
            if (roll < rarityWeight[Rarity.Super]) return Rarity.Super;
            if (roll < rarityWeight[Rarity.Legendary]) return Rarity.Legendary;
            if (roll < rarityWeight[Rarity.Epic]) return Rarity.Epic;
            if (roll < rarityWeight[Rarity.Rare]) return Rarity.Rare;
            if (roll < rarityWeight[Rarity.Magic]) return Rarity.Magic;
            
            if(level < 55) return Rarity.Normal; 
                else return Rarity.Magic;
        }

        private void UpdateRarityWeights(int level)
        {
            switch(level)
            {
                case int i when i < 13:
                    rarityWeight[Rarity.Super] = 0;
                    rarityWeight[Rarity.Legendary] = 0;
                    rarityWeight[Rarity.Epic] = 20;
                    rarityWeight[Rarity.Rare] = 100;
                    rarityWeight[Rarity.Magic] = 300;
                    rarityWeight[Rarity.Normal] = 800;
                    break;
                case int i when i >= 13 && i < 26:
                    rarityWeight[Rarity.Super] = 0;
                    rarityWeight[Rarity.Legendary] = 1;
                    rarityWeight[Rarity.Epic] = 40;
                    rarityWeight[Rarity.Rare] = 120;
                    rarityWeight[Rarity.Magic] = 300;
                    rarityWeight[Rarity.Normal] = 500;
                    break;
                case int i when i >= 26 && i < 39:
                    rarityWeight[Rarity.Super] = 2;
                    rarityWeight[Rarity.Legendary] = 5;
                    rarityWeight[Rarity.Epic] = 100;
                    rarityWeight[Rarity.Rare] = 300;
                    rarityWeight[Rarity.Magic] = 800;
                    rarityWeight[Rarity.Normal] = 300;
                    break;
                case int i when i >= 39 && i < 55:
                    rarityWeight[Rarity.Super] = 3;
                    rarityWeight[Rarity.Legendary] = 25;
                    rarityWeight[Rarity.Epic] = 150;
                    rarityWeight[Rarity.Rare] = 400;
                    rarityWeight[Rarity.Magic] = 800;
                    rarityWeight[Rarity.Normal] = 0;
                    break;
                case int i when i >= 55:
                    rarityWeight[Rarity.Super] = 25;
                    rarityWeight[Rarity.Legendary] = 100;
                    rarityWeight[Rarity.Epic] = 250;
                    rarityWeight[Rarity.Rare] = 600;
                    rarityWeight[Rarity.Magic] = 0;
                    rarityWeight[Rarity.Normal] = 0;
                    break;
            }
        }
    }


}
