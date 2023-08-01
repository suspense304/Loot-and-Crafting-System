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
            Head.PopulateHeadGear(random);
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
                case Affix.Armor: return RollArmor(level);
                case Affix.AttackSpeed: return RollLowPercentageIncrease(level);
                case Affix.CritChance: return RollLowPercentageIncrease(level);
                case Affix.CritDamage: return RollHighPercentageIncrease(level);
                case Affix.Dexterity: return RollBaseStat(level);
                case Affix.DodgeChance: return RollLowPercentageIncrease(level);
                case Affix.GoldFind: return RollHighPercentageIncrease(level);
                case Affix.HealthRegen: return RollLowPercentageIncrease(level);
                case Affix.Intelligence: return RollBaseStat(level);
                case Affix.MagicFind: return RollHighPercentageIncrease(level);
                case Affix.MovementSpeed: return RollLowPercentageIncrease(level);
                case Affix.Projectiles: return RollSkillOrProjectileIncrease(level);
                case Affix.SpellRadius: return RollLowPercentageIncrease(level);
                case Affix.Strength: return RollBaseStat(level);
                default: return new AffixValue();
            }
        }
        public AffixValue RollBaseStat(float level)
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue { MinValue = 1, MaxValue = 6, Value = random.Next(1, 6) },
                float i when i >= 10 && i < 20 => new AffixValue { MinValue = 4, MaxValue = 11, Value = random.Next(4, 11) },
                float i when i >= 20 && i < 30 => new AffixValue { MinValue = 7, MaxValue = 16, Value = random.Next(7, 16) },
                float i when i >= 30 && i < 40 => new AffixValue { MinValue = 10, MaxValue = 21, Value = random.Next(10, 21) },
                float i when i >= 40 && i < 50 => new AffixValue { MinValue = 13, MaxValue = 26, Value = random.Next(13, 26) },
                float i when i >= 50 && i < 60 => new AffixValue { MinValue = 16, MaxValue = 31, Value = random.Next(16, 31) },
                float i when i >= 60 && i < 70 => new AffixValue { MinValue = 19, MaxValue = 36, Value = random.Next(19, 36) },
                float i when i >= 70 => new AffixValue { MinValue = 22, MaxValue = 41, Value = random.Next(22, 41) },
                _ => new AffixValue { MinValue = 1, MaxValue = 6, Value = random.Next(1, 6) }
            };
            return value;
        }
        public AffixValue RollArmor(float level)
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue { MinValue = 4, MaxValue = 12, Value = random.Next(4, 12) },
                float i when i >= 10 && i < 20 => new AffixValue { MinValue = 8, MaxValue = 18, Value = random.Next(8, 18) },
                float i when i >= 20 && i < 30 => new AffixValue { MinValue = 12, MaxValue = 24, Value = random.Next(12, 24) },
                float i when i >= 30 && i < 40 => new AffixValue { MinValue = 16, MaxValue = 30, Value = random.Next(16, 30) },
                float i when i >= 40 && i < 50 => new AffixValue { MinValue = 20, MaxValue = 36, Value = random.Next(20, 36) },
                float i when i >= 50 && i < 60 => new AffixValue { MinValue = 24, MaxValue = 42, Value = random.Next(24, 42) },
                float i when i >= 60 && i < 70 => new AffixValue { MinValue = 28, MaxValue = 48, Value = random.Next(28, 48) },
                float i when i >= 70 => new AffixValue { MinValue =32, MaxValue = 54, Value = random.Next(32, 54) },
                _ => new AffixValue { MinValue = 4, MaxValue = 12, Value = random.Next(4, 12) }
            };
            return value;
        }
        public AffixValue RollLowPercentageIncrease(float level)
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue { MinValue = 1, MaxValue = 2, Value = random.Next(1, 2) },
                float i when i >= 10 && i < 20 => new AffixValue { MinValue = 1, MaxValue = 3, Value = random.Next(1, 3) },
                float i when i >= 20 && i < 30 => new AffixValue { MinValue = 2, MaxValue = 4, Value = random.Next(2, 4) },
                float i when i >= 30 && i < 40 => new AffixValue { MinValue = 2, MaxValue = 5, Value = random.Next(2, 5) },
                float i when i >= 40 && i < 50 => new AffixValue { MinValue = 3, MaxValue = 6, Value = random.Next(3, 6) },
                float i when i >= 50 && i < 60 => new AffixValue { MinValue = 4, MaxValue = 7, Value = random.Next(4, 7) },
                float i when i >= 60 && i < 70 => new AffixValue { MinValue = 4, MaxValue = 8, Value = random.Next(4, 8) },
                float i when i >= 70 => new AffixValue { MinValue = 5, MaxValue = 9, Value = random.Next(5, 9) },
                _ => new AffixValue { MinValue = 1, MaxValue = 2, Value = random.Next(1, 2) }
            };
            return value;
        }
        public AffixValue RollHighPercentageIncrease(float level)
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue { MinValue = 1, MaxValue = 4, Value = random.Next(1, 4) },
                float i when i >= 10 && i < 20 => new AffixValue { MinValue = 3, MaxValue = 7, Value = random.Next(3, 7) },
                float i when i >= 20 && i < 30 => new AffixValue { MinValue = 5, MaxValue = 10, Value = random.Next(5, 10) },
                float i when i >= 30 && i < 40 => new AffixValue { MinValue = 7, MaxValue = 13, Value = random.Next(7, 13) },
                float i when i >= 40 && i < 50 => new AffixValue { MinValue = 9, MaxValue = 16, Value = random.Next(9, 16) },
                float i when i >= 50 && i < 60 => new AffixValue { MinValue = 11, MaxValue = 19, Value = random.Next(11, 19) },
                float i when i >= 60 && i < 70 => new AffixValue { MinValue = 13, MaxValue = 22, Value = random.Next(13, 22) },
                float i when i >= 70 => new AffixValue { MinValue = 13, MaxValue = 25, Value = random.Next(13, 25) },
                _ => new AffixValue { MinValue = 1, MaxValue = 4, Value = random.Next(1, 4) }
            };
            return value;
        }
        public AffixValue RollSkillOrProjectileIncrease(float level)
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue { MinValue = 1, MaxValue = 1, Value = 1 },
                float i when i >= 30 && i < 50 => new AffixValue { MinValue = 1, MaxValue = 2, Value = random.Next(1, 2) },
                float i when i >= 50 && i < 70 => new AffixValue { MinValue = 1, MaxValue = 3, Value = random.Next(1, 3) },
                float i when i >= 70 => new AffixValue { MinValue = 2, MaxValue = 4, Value = random.Next(2, 4) },
                _ => new AffixValue { MinValue = 1, MaxValue = 1, Value = 1 }
            };
            return value;
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
            BaseItem basePiece = Head.GetBaseItem(level, random, item.Rarity, maxBucket);
            item.Name = basePiece.Name;
            item.BaseAffixes = basePiece.Affixes;
            item.Armor = basePiece.Armor ?? null;
            item.AttackDamage = basePiece.AttackDamge ?? null;
            item.RequiredLevel = basePiece.RequiredLevel;

            return item;
        }

        private EquipmentItem GetLegendaryEquipmentItem(EquipmentItem item, int level, int maxBucket)
        {
            var legendaryItems = Head.GetLegendaryItems().Where(w => GetBucket(w.RequiredLevel) <= maxBucket).ToList();
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

            if(slot == GearSlot.Head)
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
        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
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
