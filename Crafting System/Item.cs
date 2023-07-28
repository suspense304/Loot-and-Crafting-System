using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System
{
    public class EquipmentItem
    {
        public string Name { get; set; } = string.Empty;
        public Rarity Rarity { get; set; }
        public GearSlot Slot { get; set; }
        public List<Affix> Prefixes { get; set; }
        public List<Affix> Suffixes { get; set; }
        public int MaxAffix => GetMaxAffix();
        private const int MaxAffixesPerType = 3;

        public EquipmentItem()
        {
            Name = string.Empty;
            Rarity = Rarity.Normal;
            Slot = GearSlot.Chest;
            Prefixes = new List<Affix>();
            Suffixes = new List<Affix>();
        }

        public bool AddAffix(Affix affix, AffixType affixType)
        {
            List<Affix> affixList = affixType == AffixType.Prefix ? Prefixes : Suffixes;

            if (affixList.Count < MaxAffixesPerType)
            {
                affixList.Add(affix);
                return true;
            }

            return false;
        }
        int GetMaxAffix()
        {
            switch(Rarity)
            {
                case Rarity.Normal: return 0;
                case Rarity.Magic: return 2;
                case Rarity.Rare: return 3;
                case Rarity.Epic: return 4;
                case Rarity.Legendary: return 5;
                case Rarity.Super: return 6;
            }

            return 0;
        }
    }

    public class ItemAffix
    {
        public Affix Type { get; private set; }
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        private Random Random { get; set; }

        public ItemAffix(Affix type, int minValue, int maxValue, Random random)
        {
            Type = type;
            MinValue = minValue;
            MaxValue = maxValue;
            Random = random;
        }

        public int CalculateModifier()
        {
            return Random.Next(MinValue, MaxValue);
        }
    }

    public class ItemCreationService
    {
        private Random random = new Random();
        Dictionary<GearSlot, List<Affix>> _gearSlotPrefixPools = new Dictionary<GearSlot, List<Affix>>();
        Dictionary<GearSlot, List<Affix>> _gearSlotSuffixPools = new Dictionary<GearSlot, List<Affix>>();

        const int NORMAL_RARITY_WEIGHT = 1200;
        const int MAGIC_RARITY_WEIGHT = 650;
        const int RARE_RARITY_WEIGHT = 350;
        const int EPIC_RARITY_WEIGHT = 125;
        const int LEGENDARY_RARITY_WEIGHT = 50;
        const int SUPER_RARITY_WEIGHT = 10;
        const int RARITY_WEIGHT = 2385;
        public ItemCreationService()
        {
            CreateGearSlotAffixPools();
        }

        public GearSlot GetRandomGearSlot()
        {
            Array gearSlots = Enum.GetValues(typeof(GearSlot));
            int randomIndex = random.Next(0, gearSlots.Length);
            return (GearSlot)gearSlots.GetValue(randomIndex);
        }
        public void CreateGearSlotAffixPools()
        {
            foreach (GearSlot slot in Enum.GetValues(typeof(GearSlot)))
            {
                List<Affix> prefixesForSlot = GetAffixesForSlot(slot, AffixType.Prefix);
                List<Affix> suffixesForSlot = GetAffixesForSlot(slot, AffixType.Suffix);

                _gearSlotPrefixPools.Add(slot, prefixesForSlot);
                _gearSlotSuffixPools.Add(slot, suffixesForSlot);
            }
        }
        private List<Affix> GetAffixesForSlot(GearSlot slot, AffixType affixType)
        {
            List<Affix> affixes = new List<Affix>();

            // Add the appropriate affixes for each GearSlot and AffixType
            switch (slot)
            {
                case GearSlot.Head:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.GoldFind,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.Shoulders:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                        });
                    break;
                case GearSlot.Chest:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.Gloves:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Projectiles,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.Belt:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.Pants:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Projectiles,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.MovementSpeed,
                        });
                    break;
                case GearSlot.Boots:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.MovementSpeed,
                        });
                    break;
                case GearSlot.Ring:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.MovementSpeed,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.Amulet:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Projectiles,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.MovementSpeed,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.MainHand:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Projectiles,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                case GearSlot.OffHand:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            Affix.AttackSpeed,
                            Affix.CritChance,
                            Affix.CritDamage,
                            Affix.Dexterity,
                            Affix.Intelligence,
                            Affix.Projectiles,
                            Affix.Strength,
                            Affix.Willpower,
                        }
                        : new[] {
                            Affix.DodgeChance,
                            Affix.GoldFind,
                            Affix.HealthRegen,
                            Affix.MagicFind,
                            Affix.SpellRadius,
                        });
                    break;
                default:
                    break;
            }

            return affixes;
        }
        public int RollBaseStat(int level)
        {
            int value = level switch
            {
                int i when i < 10 => random.Next(1, 6),
                int i when i >= 10 && i < 20 => random.Next(4, 11),
                int i when i >= 20 && i < 30 => random.Next(7, 16),
                int i when i >= 30 && i < 40 => random.Next(10, 21),
                int i when i >= 40 && i < 50 => random.Next(13, 26),
                int i when i >= 50 && i < 60 => random.Next(16, 31),
                int i when i >= 60 && i < 70 => random.Next(19, 36),
                int i when i >= 70 => random.Next(22, 41),
                _ => random.Next(1, 41)
            };
            return value;
        }
        public int RollArmor(int level)
        {
            int value = level switch
            {
                int i when i < 10 => random.Next(4, 12),
                int i when i >= 10 && i < 20 => random.Next(8, 18),
                int i when i >= 20 && i < 30 => random.Next(12, 24),
                int i when i >= 30 && i < 40 => random.Next(16, 30),
                int i when i >= 40 && i < 50 => random.Next(20, 36),
                int i when i >= 50 && i < 60 => random.Next(24, 42),
                int i when i >= 60 && i < 70 => random.Next(28, 48),
                int i when i >= 70 => random.Next(32, 54),
                _ => random.Next(4, 54)
            };
            return value;
        }
        public int RollLowPercentageIncrease(int level)
        {
            int value = level switch
            {
                int i when i < 10 => random.Next(1, 2),
                int i when i >= 10 && i < 20 => random.Next(1, 3),
                int i when i >= 20 && i < 30 => random.Next(2, 4),
                int i when i >= 30 && i < 40 => random.Next(2, 5),
                int i when i >= 40 && i < 50 => random.Next(3, 6),
                int i when i >= 50 && i < 60 => random.Next(3, 7),
                int i when i >= 60 && i < 70 => random.Next(4, 8),
                int i when i >= 70 => random.Next(4, 9),
                _ => random.Next(1, 9)
            };
            return value;
        }
        public int RollHighPercentageIncrease(int level)
        {
            int value = level switch
            {
                int i when i < 10 => random.Next(1, 4),
                int i when i >= 10 && i < 20 => random.Next(3, 7),
                int i when i >= 20 && i < 30 => random.Next(5, 10),
                int i when i >= 30 && i < 40 => random.Next(7, 13),
                int i when i >= 40 && i < 50 => random.Next(9, 16),
                int i when i >= 50 && i < 60 => random.Next(11, 19),
                int i when i >= 60 && i < 70 => random.Next(13, 22),
                int i when i >= 70 => random.Next(13, 25),
                _ => random.Next(1, 25)
            };
            return value;
        }
        public EquipmentItem CreateEquipmentItem(int level, GearSlot slot)
        {
            EquipmentItem item = new EquipmentItem();
            item.Rarity = RollRarity(level);
            item.Name = item.Rarity.ToString();
            item.Slot = slot;

            List<Affix> prefixes = RollAffixes(slot, AffixType.Prefix);
            List<Affix> suffixes = RollAffixes(slot, AffixType.Suffix);

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

                if (canAddPrefix && (!canAddSuffix || random.Next(0, 2) == 0))
                {
                    item.AddAffix(prefixes[random.Next(0, prefixes.Count)], AffixType.Prefix);
                    remainingAffixes--;
                }
                else if (canAddSuffix)
                {
                    item.AddAffix(suffixes[random.Next(0, suffixes.Count)], AffixType.Suffix);
                    remainingAffixes--;
                }
            }

            // Calculate and apply the stat modifiers based on the affixes

            return item;
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

        private List<Affix> RollAffixes(GearSlot slot, AffixType affixType)
        {
            Dictionary<GearSlot, List<Affix>> affixPools = affixType == AffixType.Prefix
                ? _gearSlotPrefixPools
                : _gearSlotSuffixPools;

            List<Affix> affixes = affixPools[slot];
            // Perform random selection or any additional logic you need here

            return affixes;
        }
        private Rarity RollRarity(int level)
        {
            int roll = random.Next(1, RARITY_WEIGHT - (level * 20));
            if (roll < SUPER_RARITY_WEIGHT) return Rarity.Super;
            if (roll < LEGENDARY_RARITY_WEIGHT) return Rarity.Legendary;
            if (roll < EPIC_RARITY_WEIGHT) return Rarity.Epic;
            if (roll < RARE_RARITY_WEIGHT) return Rarity.Rare;
            if (roll < MAGIC_RARITY_WEIGHT) return Rarity.Magic;
            return Rarity.Normal;
        }
    }

    
}
