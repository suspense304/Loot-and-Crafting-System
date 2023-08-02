using Crafting_System.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Crafting_System.Gear
{
    public partial class Head : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            _legendaryItems.Add(new EquipmentItem
            {
                Name = "Kalen's Crown",
                Armor = 188,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Head,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(10, 20, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(84, 125, random),
                    },
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_Projectiles)
                    {
                        Values = new AffixValue(3, 5, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(20, 30, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(20, 25, random),
                    },
                },
            });
        }

        public override void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                                    ? new[] {
                            new ItemAffix(Affix.Prefix_AllSkills),
                            new ItemAffix(Affix.Prefix_CritChance),
                            new ItemAffix(Affix.Prefix_CritDamage),
                            new ItemAffix(Affix.Prefix_Dexterity),
                            new ItemAffix(Affix.Prefix_ColdDamage),
                            new ItemAffix(Affix.Prefix_FireDamage),
                            new ItemAffix(Affix.Prefix_LightningDamage),
                            new ItemAffix(Affix.Prefix_Life),
                            new ItemAffix(Affix.Prefix_Intelligence),
                            new ItemAffix(Affix.Prefix_Strength),
                            }
                                    : new[] {
                            new ItemAffix(Affix.Suffix_GoldFind),
                            new ItemAffix(Affix.Suffix_MagicFind),
                            new ItemAffix(Affix.Suffix_SpellRadius),
                            });
        }

        public override void GetLevelOneItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelOneStr.GetDisplayName(),
                Armor = random.Next(4, 10),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(1, 3, random),
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
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(1, 3, random),
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
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        public override void GetLevelTwoItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelTwoStr.GetDisplayName(),
                Armor = random.Next(18, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(4, 7, random),
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
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(4, 7, random),
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
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(4, 7, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Two,
                RequiredLevel = 13,
            });
        }

        public override void GetLevelThreeItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelThreeStr.GetDisplayName(),
                Armor = random.Next(28, 45),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(7, 12, random),
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
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(7, 12, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelThreeInt.GetDisplayName(),
                Armor = random.Next(21, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(7, 12, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
        }

        public override void GetLevelFourItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFourStr.GetDisplayName(),
                Armor = random.Next(70, 102),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(11, 18, random),
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
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(11, 18, random),
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
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(11, 18, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Four,
                RequiredLevel = 39,
            });
        }

        public override void GetLevelFiveItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelFiveStr.GetDisplayName(),
                Armor = random.Next(124, 155),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(17, 31, random),
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
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(17, 31, random),
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
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(17, 31, random),
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
