using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System
{

    public class ItemCreationService
    {
        private Random random = new Random();
        Dictionary<GearSlot, List<ItemAffix>> _gearSlotPrefixPools = new Dictionary<GearSlot, List<ItemAffix>>();
        Dictionary<GearSlot, List<ItemAffix>> _gearSlotSuffixPools = new Dictionary<GearSlot, List<ItemAffix>>();

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
                List<ItemAffix> prefixesForSlot = GetAffixesForSlot(slot, AffixType.Prefix);
                List<ItemAffix> suffixesForSlot = GetAffixesForSlot(slot, AffixType.Suffix);

                _gearSlotPrefixPools.Add(slot, prefixesForSlot);
                _gearSlotSuffixPools.Add(slot, suffixesForSlot);
            }
        }
        private List<ItemAffix> GetAffixesForSlot(GearSlot slot, AffixType affixType)
        {
            List<ItemAffix> affixes = new List<ItemAffix>();

            // Add the appropriate affixes for each GearSlot and AffixType
            switch (slot)
            {
                case GearSlot.Head:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.Shoulders:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                        });
                    break;
                case GearSlot.Chest:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.Gloves:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Projectiles, 1, 5, Affix.Projectiles),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.Belt:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.Pants:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.MovementSpeed, 1, 5, Affix.MovementSpeed),
                        });
                    break;
                case GearSlot.Boots:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.MovementSpeed, 1, 5, Affix.MovementSpeed),
                        });
                    break;
                case GearSlot.Ring:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.MovementSpeed, 1, 5, Affix.MovementSpeed),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.Amulet:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Projectiles, 1, 5, Affix.Projectiles),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.MovementSpeed, 1, 5, Affix.MovementSpeed),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.MainHand:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Projectiles, 1, 5, Affix.Projectiles),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
                        });
                    break;
                case GearSlot.OffHand:
                    affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed, 1, 5, Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance, 1, 5, Affix.CritChance),
                            new ItemAffix(Affix.CritDamage, 1, 5, Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity, 1, 5, Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence, 1, 5, Affix.Intelligence),
                            new ItemAffix(Affix.Projectiles, 1, 5, Affix.Projectiles),
                            new ItemAffix(Affix.Strength, 1, 5, Affix.Strength),
                            new ItemAffix(Affix.Willpower, 1, 5, Affix.Willpower),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance, 1, 5, Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind, 1, 5, Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen, 1, 5, Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind, 1, 5, Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius, 1, 5, Affix.SpellRadius),
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
        private List<ItemAffix> RollAffixes(GearSlot slot, AffixType affixType)
        {
            Dictionary<GearSlot, List<ItemAffix>> affixPools = affixType == AffixType.Prefix
                ? _gearSlotPrefixPools
                : _gearSlotSuffixPools;

            List<ItemAffix> affixes = affixPools[slot];
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
