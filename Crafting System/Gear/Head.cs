using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Crafting_System.Gear
{
    public class Head
    {
        private static List<BaseItem> _baseItems = new List<BaseItem>();
        private static List<LevelBucket> _buckets = new List<LevelBucket>();

        public static void PopulateHeadGear(Random random)
        {
            GetLevelOneItems(random);
            GetLevelTwoItems(random);
            GetLevelThreeItems(random);
            GetLevelFourItems(random);
            GetLevelFiveItems(random);
            _buckets.Add(LevelBucket.One);
            _buckets.Add(LevelBucket.Two);
            _buckets.Add(LevelBucket.Three);
            _buckets.Add(LevelBucket.Four);
            _buckets.Add(LevelBucket.Five);
        }
        public static void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                                    ? new[] {
                            new ItemAffix(Affix.CritChance),
                            new ItemAffix(Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence),
                            new ItemAffix(Affix.Strength),
                            }
                                    : new[] {
                            new ItemAffix(Affix.GoldFind),
                            new ItemAffix(Affix.MagicFind),
                            new ItemAffix(Affix.SpellRadius),
                            });
        }

        public static BaseItem GetBaseItem(int level, Random random, Rarity rarity)
        {
            int itemLevel = random.Next(level - 3, level + 3);

            BaseItem value = itemLevel switch
            {
                int i when i < 13 => GetRandomBaseItem(1, random),
                int i when i >= 13 && i < 26 => GetRandomBaseItem(2, random),
                int i when i >= 26 && i < 39 => GetRandomBaseItem(3, random),
                int i when i >= 39 && i < 55 => GetRandomBaseItem(4, random),
                int i when i >= 55 => GetRandomBaseItem(5, random),
                _ => GetRandomBaseItem(1, random),
            };

            return value;
        }

        private static BaseItem GetRandomBaseItem(int maxBucket, Random random)
        {
            LevelBucket bucket = _buckets[random.Next(0, maxBucket)];

            List<BaseItem> weight = _baseItems.Where(w => w.LevelBucket == bucket).ToList();
            var roll = random.Next(0, _baseItems.Where(w => w.LevelBucket == bucket).Sum(s => s.RollWeight));

            for(int i = 0; i < _baseItems.Count; i++)
            {
                roll -= _baseItems[i].RollWeight;

                if(roll <= 0)
                {
                    return weight[i];
                }
            }

            return weight[0];
        }

        private static void GetLevelOneItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelOneStr.GetDisplayName(),
                Armor = random.Next(4, 10),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Strength)
                    {
                        Values = new AffixValue { MinValue = 1, MaxValue = 3, Value = random.Next(1, 3)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelOneDex.GetDisplayName(),
                Armor = random.Next(3, 6),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Intelligence)
                    {
                        Values = new AffixValue { MinValue = 1, MaxValue = 3, Value = random.Next(1, 3)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelOneInt.GetDisplayName(),
                Armor = random.Next(1, 4),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Dexterity)
                    {
                        Values = new AffixValue { MinValue = 1, MaxValue = 3, Value = random.Next(1, 3)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        private static void GetLevelTwoItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelTwoStr.GetDisplayName(),
                Armor = random.Next(18, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Strength)
                    {
                        Values = new AffixValue { MinValue = 4, MaxValue = 7, Value = random.Next(4, 7)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Two,
                RequiredLevel = 13,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelTwoDex.GetDisplayName(),
                Armor = random.Next(12, 23),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Dexterity)
                    {
                        Values = new AffixValue { MinValue = 4, MaxValue = 7, Value = random.Next(4, 7)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Two,
                RequiredLevel = 13,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelTwoInt.GetDisplayName(),
                Armor = random.Next(7, 16),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Intelligence)
                    {
                        Values = new AffixValue { MinValue = 4, MaxValue = 7, Value = random.Next(4, 7)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Two,
                RequiredLevel = 13,
            });
        }

        private static void GetLevelThreeItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelThreeStr.GetDisplayName(),
                Armor = random.Next(28, 45),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Strength)
                    {
                        Values = new AffixValue { MinValue = 7, MaxValue = 12, Value = random.Next(7, 12)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelThreeDex.GetDisplayName(),
                Armor = random.Next(24, 37),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Dexterity)
                    {
                        Values = new AffixValue { MinValue = 7, MaxValue = 12, Value = random.Next(7, 12)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelThreeInt.GetDisplayName(),
                Armor = random.Next(21,30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Intelligence)
                    {
                        Values = new AffixValue { MinValue = 7, MaxValue = 12, Value = random.Next(7, 12)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
        }

        private static void GetLevelFourItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFourStr.GetDisplayName(),
                Armor = random.Next(70, 102),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Strength)
                    {
                        Values = new AffixValue { MinValue = 11, MaxValue = 18, Value = random.Next(11, 18)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Four,
                RequiredLevel = 39,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFourDex.GetDisplayName(),
                Armor = random.Next(45, 73),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Dexterity)
                    {
                        Values = new AffixValue { MinValue = 11, MaxValue = 18, Value = random.Next(11, 18)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Four,
                RequiredLevel = 39,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFourInt.GetDisplayName(),
                Armor = random.Next(34, 61),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Intelligence)
                    {
                        Values = new AffixValue { MinValue = 11, MaxValue = 18, Value = random.Next(11, 18)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Four,
                RequiredLevel = 39,
            });
        }

        private static void GetLevelFiveItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFiveStr.GetDisplayName(),
                Armor = random.Next(124, 155),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Strength)
                    {
                        Values = new AffixValue { MinValue = 17, MaxValue = 31, Value = random.Next(17, 31)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Five,
                RequiredLevel = 55,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFiveDex.GetDisplayName(),
                Armor = random.Next(65, 104),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Dexterity)
                    {
                        Values = new AffixValue { MinValue = 17, MaxValue = 31, Value = random.Next(17, 31)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Five,
                RequiredLevel = 55,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFiveInt.GetDisplayName(),
                Armor = random.Next(58, 92),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Intelligence)
                    {
                        Values = new AffixValue { MinValue = 17, MaxValue = 31, Value = random.Next(17, 31)  },
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Five,
                RequiredLevel = 55,
            });
        }
    }

    enum HeadItems
    {
        [Display(Name = "Torn Helm")] // Level One
        LevelOneStr,
        [Display(Name = "Crown of Despair")] // Level One
        LevelOneInt,
        [Display(Name = "Helm of Torment")] // Level One
        LevelOneDex,

        [Display(Name = "Cherished Crown")] // Level Two
        LevelTwoStr,
        [Display(Name = "Polished Helm")] // Level Two
        LevelTwoInt,
        [Display(Name = "Forgotten Helm")] // Level Two
        LevelTwoDex,

        [Display(Name = "Reinforced Cap")] // Level Three
        LevelThreeStr,
        [Display(Name = "Blessed Crown")] // Level Three
        LevelThreeInt,
        [Display(Name = "Helm of Haste")] // Level Three
        LevelThreeDex,

        [Display(Name = "Vanquisher's Helm")] // Level Four
        LevelFourStr,
        [Display(Name = "Enlightened Crown")] // Level Four
        LevelFourInt,
        [Display(Name = "Helm of Precision")] // Level Four
        LevelFourDex,

        [Display(Name = "Gladiator Helm")] // Level Five
        LevelFiveStr,
        [Display(Name = "Wizard's Hat")] // Level Five
        LevelFiveInt,
        [Display(Name = "Ranger's Cap")] // Level Five
        LevelFiveDex,
    }


}
