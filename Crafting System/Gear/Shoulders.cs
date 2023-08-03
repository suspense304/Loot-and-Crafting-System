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
    public partial class Shoulders : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Elemental Mantle",
                Armor = 40,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Shoulders,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CooldownReduction)
                    {
                        Values = new AffixValue(10, 20, random),
                    },
                    new ItemAffix(Affix.Prefix_Life)
                    {
                        Values = new AffixValue(25, 50, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_ColdDamage)
                    {
                        Values = new AffixValue(25, 75, random),
                    },
                    new ItemAffix(Affix.Prefix_ColdSkills)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(30, 55, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                    new ItemAffix(Affix.Suffix_SpellRadius)
                    {
                        Values = new AffixValue(25, 50, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(1, 100, random),
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
                        });
        }

        public override void GetLevelTwoItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelTwoStr.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelTwoDex.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelTwoInt.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelThreeStr.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelThreeDex.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelThreeInt.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFourStr.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFourDex.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFourInt.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFiveStr.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFiveDex.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelFiveInt.GetDisplayName(),
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

    enum ShoulderItems
    {

        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoStr,
        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoInt,
        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoDex,

        [Display(Name = "Leather Shoulders of Power")] // Level Three
        LevelThreeStr,
        [Display(Name = "Leather Shoulders of Wisdom")] // Level Three
        LevelThreeInt,
        [Display(Name = "Leather Shoulders of Speed")] // Level Three
        LevelThreeDex,

        [Display(Name = "Iron Shoulders of Power")] // Level Four
        LevelFourStr,
        [Display(Name = "Iron Shoulders of Wisdom")] // Level Four
        LevelFourInt,
        [Display(Name = "Iron Shoulders of Speed")] // Level Four
        LevelFourDex,

        [Display(Name = "Diamond Shoulders of Power")] // Level Five
        LevelFiveStr,
        [Display(Name = "Diamond Shoulders of Wisdom")] // Level Five
        LevelFiveInt,
        [Display(Name = "Diamond Shoulders of Speed")] // Level Five
        LevelFiveDex,
    }
}
