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
    public partial class Chest : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            _legendaryItems.Add(new EquipmentItem
            {
                Name = "Commander's Plate",
                Armor = 455,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Chest,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Life)
                    {
                        Values = new AffixValue(180, 245, random),
                    },
                    new ItemAffix(Affix.Prefix_Armor)
                    {
                        Values = new AffixValue(135, 188, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AllSkills)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(35, 55, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_HealthRegen)
                    {
                        Values = new AffixValue(4, 6, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                },
            });
        }

        public override void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.Prefix_CritChance),
                            new ItemAffix(Affix.Prefix_CritDamage),
                            new ItemAffix(Affix.Prefix_Dexterity),
                            new ItemAffix(Affix.Prefix_Intelligence),
                            new ItemAffix(Affix.Prefix_Strength),
                        }
                        : new[] {
                            new ItemAffix(Affix.Suffix_DodgeChance),
                            new ItemAffix(Affix.Suffix_GoldFind),
                            new ItemAffix(Affix.Suffix_HealthRegen),
                            new ItemAffix(Affix.Suffix_MagicFind),
                            new ItemAffix(Affix.Suffix_SpellRadius),
                        });
        }

        public override void GetLevelOneItems(Random random)
        {
            _baseItems.Add(new BaseItem
            {
                Name = ChestItems.LevelOneStr.GetDisplayName(),
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
                Name = ChestItems.LevelOneDex.GetDisplayName(),
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
                Name = ChestItems.LevelOneInt.GetDisplayName(),
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
                Name = ChestItems.LevelTwoStr.GetDisplayName(),
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
                Name = ChestItems.LevelTwoDex.GetDisplayName(),
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
                Name = ChestItems.LevelTwoInt.GetDisplayName(),
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
                Name = ChestItems.LevelThreeStr.GetDisplayName(),
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
                Name = ChestItems.LevelThreeDex.GetDisplayName(),
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
                Name = ChestItems.LevelThreeInt.GetDisplayName(),
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
                Name = ChestItems.LevelFourStr.GetDisplayName(),
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
                Name = ChestItems.LevelFourDex.GetDisplayName(),
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
                Name = ChestItems.LevelFourInt.GetDisplayName(),
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
                Name = ChestItems.LevelFiveStr.GetDisplayName(),
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
                Name = ChestItems.LevelFiveDex.GetDisplayName(),
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
                Name = ChestItems.LevelFiveInt.GetDisplayName(),
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

    enum ChestItems
    {
        [Display(Name = "Worn Chest")] // Level One
        LevelOneStr,
        [Display(Name = "Torn Robe")] // Level One
        LevelOneInt,
        [Display(Name = "Worn Vest")] // Level One
        LevelOneDex,

        [Display(Name = "Padded Chest")] // Level Two
        LevelTwoStr,
        [Display(Name = "Cloth Robe")] // Level Two
        LevelTwoInt,
        [Display(Name = "Cloth Vest")] // Level Two
        LevelTwoDex,

        [Display(Name = "Reinforced Chest")] // Level Three
        LevelThreeStr,
        [Display(Name = "Silk Robe")] // Level Three
        LevelThreeInt,
        [Display(Name = "Fitted Vest")] // Level Three
        LevelThreeDex,

        [Display(Name = "Polished Chest")] // Level Four
        LevelFourStr,
        [Display(Name = "Stylish Robe")] // Level Four
        LevelFourInt,
        [Display(Name = "Hardened Vest")] // Level Four
        LevelFourDex,

        [Display(Name = "Gladiator Plate")] // Level Five
        LevelFiveStr,
        [Display(Name = "Wizard's Robe")] // Level Five
        LevelFiveInt,
        [Display(Name = "Ranger's Vest")] // Level Five
        LevelFiveDex,
    }
}
