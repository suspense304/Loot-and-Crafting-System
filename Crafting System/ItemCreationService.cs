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
        public static ItemCreationService Instance;
        private Random random = new Random();
        private Dictionary<Rarity, int> rarityWeight = new Dictionary<Rarity, int>();

        public static List<BaseItem> BaseItems = new List<BaseItem>();
        public static List<EquipmentItem> LegendaryItems = new List<EquipmentItem>();

        int NORMAL_RARITY_WEIGHT = 600;
        int MAGIC_RARITY_WEIGHT = 250;
        int RARE_RARITY_WEIGHT = 100;
        int EPIC_RARITY_WEIGHT = 40;
        int LEGENDARY_RARITY_WEIGHT = 7;
        int SUPER_RARITY_WEIGHT = 3;

        public ItemCreationService()
        {
            Instance = this;
            new Amulet().PopulateGear(random);
            new Belt().PopulateGear(random);
            new Boots().PopulateGear(random);
            new Chest().PopulateGear(random);
            new Gloves().PopulateGear(random);
            new Head().PopulateGear(random);
            new MainHand().PopulateGear(random);
            new OffHandItem().PopulateGear(random);
            new Pants().PopulateGear(random);
            new Ring().PopulateGear(random);
            new Shoulders().PopulateGear(random);
            rarityWeight.Add(Rarity.Normal, NORMAL_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Magic, MAGIC_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Rare, RARE_RARITY_WEIGHT);
            rarityWeight.Add(Rarity.Legendary, LEGENDARY_RARITY_WEIGHT);
        }

        public AffixValue GetAffixValue(Affix affix, int level)
        {
            switch (affix)
            {
                case Affix.Prefix_Armor: return new AffixCreator().RollArmor(level, random);
                case Affix.Prefix_AttackSpeed: return new AffixCreator().RollAttackSpeed(level, random);
                case Affix.Prefix_CooldownReduction: return new AffixCreator().RollCooldownReduction(level, random);
                case Affix.Prefix_CritChance: return new AffixCreator().RollCritChance(level, random);
                case Affix.Prefix_CritDamage: return new AffixCreator().RollCritDamage(level, random);
                case Affix.Prefix_PhysicalDamage: return new AffixCreator().RollDamageIncrease(level, random);
                case Affix.Prefix_SpellDamage: return new AffixCreator().RollDamageIncrease(level, random);
                case Affix.Prefix_Life: return new AffixCreator().RollLife(level, random);
                case Affix.Suffix_DodgeChance: return new AffixCreator().RollDodgeChance(level, random);
                case Affix.Suffix_GoldFind: return new AffixCreator().RollGoldFind(level, random);
                case Affix.Suffix_HealthRegen: return new AffixCreator().RollHealthRegen(level, random);
                case Affix.Suffix_MagicFind: return new AffixCreator().RollMagicFind(level, random);
                case Affix.Suffix_MobDensity: return new AffixCreator().RollCritChance(level, random);
                case Affix.Suffix_MovementSpeed: return new AffixCreator().RollMovementSpeed(level, random);
                case Affix.Suffix_PickupRadius: return new AffixCreator().RollMovementSpeed(level, random);
                case Affix.Suffix_Projectiles: return new AffixCreator().RollProjectiles(level, random);
                case Affix.Suffix_SpellDuration: return new AffixCreator().RollSpellRadius(level, random);
                case Affix.Suffix_SpellRadius: return new AffixCreator().RollSpellRadius(level, random);
                
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

        private EquipmentItem? GetNonLegendaryEquipmentItem(EquipmentItem item, int level, int maxBucket)
        {
            BaseItem? basePiece = new BaseItem();
            switch (item.Slot)
            {
                case GearSlot.Amulet:
                    basePiece = new Amulet().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Belt:
                    basePiece = new Belt().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Boots:
                    basePiece = new Boots().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Chest:
                    basePiece = new Chest().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Gloves:
                    basePiece = new Gloves().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Head:
                    basePiece = new Head().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.MainHand:
                    basePiece = new MainHand().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.OffHand:
                    basePiece = new OffHandItem().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Pants:
                    basePiece = new Pants().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Ring:
                    basePiece = new Ring().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;
                case GearSlot.Shoulders:
                    basePiece = new Shoulders().GetBaseItem(level, random, item.Rarity, maxBucket);
                    break;

            }

            if (basePiece == null) return null;

            item.Name = basePiece.Name;
            item.BaseAffixes = basePiece.Affixes;
            item.Armor = basePiece.Armor ?? null;
            item.AttackDamage = basePiece.AttackDamge ?? null;
            item.RequiredLevel = basePiece.RequiredLevel;

            return item;
        }

        private EquipmentItem? GetLegendaryEquipmentItem(EquipmentItem? item, int level, int maxBucket)
        {
            if(item == null) return null;
            var legendaryItems = new List<EquipmentItem>();
            switch (item.Slot)
            {
                case GearSlot.Amulet:
                    legendaryItems = new Amulet().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Belt:
                    legendaryItems = new Belt().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Boots:
                    legendaryItems = new Boots().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Chest:
                    legendaryItems = new Chest().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Gloves:
                    legendaryItems = new Gloves().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Head:
                    legendaryItems = new Head().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.MainHand:
                    legendaryItems = new MainHand().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.OffHand:
                    legendaryItems = new OffHandItem().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Pants:
                    legendaryItems = new Pants().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Ring:
                    legendaryItems = new Ring().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
                case GearSlot.Shoulders:
                    legendaryItems = new Shoulders().GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
                    break;
            }

            if (legendaryItems.Any())
            {
                var legendaryRoll = random.Next(legendaryItems.Count);
                item = legendaryItems[legendaryRoll];
                if(item != null)
                {
                    RerollAffixes(item, level);
                }
            } else
            {
                item.Rarity = Rarity.Rare;
                item = GetNonLegendaryEquipmentItem(item, level, maxBucket);
            }

            return item;
        }

        public EquipmentItem RerollAffixes(EquipmentItem item, int level)
        {
            foreach(ItemAffix affix in item.BaseAffixes)
            {
                affix.Values = new ItemCreationService().GetAffixValue(affix.Affix, level);
            }

            foreach (ItemAffix affix in item.Prefixes)
            {
                affix.Values = new ItemCreationService().GetAffixValue(affix.Affix, level);
            }

            foreach (ItemAffix affix in item.Suffixes)
            {
                affix.Values = new ItemCreationService().GetAffixValue(affix.Affix, level);
            }

            return item;
        }

        public EquipmentItem? CreateEquipmentItem(int level, GearSlot slot)
        {
            EquipmentItem? item = new EquipmentItem();
            item.Rarity = RollRarity(level);
            item.Slot = slot;

            int maxBucket = GetBucket(level);

            if (item.Rarity == Rarity.Legendary)
            {
                item = GetLegendaryEquipmentItem(item, level, maxBucket);

            } else
            {
                item = GetNonLegendaryEquipmentItem(item, level, maxBucket);
            }

            if (item == null) return null;

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
            if (roll < rarityWeight[Rarity.Legendary]) return Rarity.Legendary;
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
                    rarityWeight[Rarity.Legendary] = 0;
                    rarityWeight[Rarity.Rare] = 100;
                    rarityWeight[Rarity.Magic] = 300;
                    rarityWeight[Rarity.Normal] = 800;
                    break;
                case int i when i >= 13 && i < 26:
                    rarityWeight[Rarity.Legendary] = 1;
                    rarityWeight[Rarity.Rare] = 120;
                    rarityWeight[Rarity.Magic] = 300;
                    rarityWeight[Rarity.Normal] = 500;
                    break;
                case int i when i >= 26 && i < 39:
                    rarityWeight[Rarity.Legendary] = 5;
                    rarityWeight[Rarity.Rare] = 300;
                    rarityWeight[Rarity.Magic] = 800;
                    rarityWeight[Rarity.Normal] = 300;
                    break;
                case int i when i >= 39 && i < 55:
                    rarityWeight[Rarity.Legendary] = 25;
                    rarityWeight[Rarity.Rare] = 400;
                    rarityWeight[Rarity.Magic] = 800;
                    rarityWeight[Rarity.Normal] = 0;
                    break;
                case int i when i >= 55:
                    rarityWeight[Rarity.Legendary] = 100;
                    rarityWeight[Rarity.Rare] = 600;
                    rarityWeight[Rarity.Magic] = 0;
                    rarityWeight[Rarity.Normal] = 0;
                    break;
            }
        }
    }


}
