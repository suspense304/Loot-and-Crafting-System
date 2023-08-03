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
    public class MainHand : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Sword of Destiny",
                AttackDamage = 88,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.MainHand,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(17, 25, random),
                    },
                    new ItemAffix(Affix.Prefix_FireDamage)
                    {
                        Values = new AffixValue(35, 50, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_FireSkills)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(7, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Mayhem",
                AttackDamage = 108,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.MainHand,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_LightningDamage)
                    {
                        Values = new AffixValue(30, 75, random),
                    },
                    new ItemAffix(Affix.Prefix_LightningSkills)
                    {
                        Values = new AffixValue(1, 4, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(20, 45, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_HealthRegen)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Seeker's Bow",
                AttackDamage = 65,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.MainHand,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(30, 50, random),
                    },
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(30, 40, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_ColdSkills)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(7, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_Projectiles)
                    {
                        Values = new AffixValue(2, 5, random),
                    },
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Wand of Omen",
                AttackDamage = 50,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.MainHand,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(50, 65, random),
                    },
                    new ItemAffix(Affix.Prefix_AllSkills)
                    {
                        Values = new AffixValue(2, 4, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_FireDamage)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Prefix_LightningDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_CooldownReduction)
                    {
                        Values = new AffixValue(10, 20, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_SpellRadius)
                    {
                        Values = new AffixValue(13, 25, random),
                    },
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
            });
        }

        public override void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.Prefix_AttackSpeed),
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
                            new ItemAffix(Affix.Suffix_Projectiles),
                            new ItemAffix(Affix.Suffix_SpellRadius),
                        });
        }

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelOneSword.GetDisplayName(),
                AttackDamge = random.Next(3, 8),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(2, 4, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelOneAxe.GetDisplayName(),
                AttackDamge = random.Next(4, 10),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(2, 4, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelOneCrossbow.GetDisplayName(),
                AttackDamge = random.Next(3, 7),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(2, 5, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelOneWand.GetDisplayName(),
                AttackDamge = random.Next(2, 5),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(3, 6, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        public override void GetLevelTwoItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelTwoSword.GetDisplayName(),
                AttackDamge = random.Next(11, 17),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(4, 8, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelTwoAxe.GetDisplayName(),
                AttackDamge = random.Next(13, 24),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(4, 9, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelTwoCrossbow.GetDisplayName(),
                AttackDamge = random.Next(9, 16),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(6, 11, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelTwoWand.GetDisplayName(),
                AttackDamge = random.Next(8, 14),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(7, 13, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        public override void GetLevelThreeItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelThreeSword.GetDisplayName(),
                AttackDamge = random.Next(19, 28),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(9, 13, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelThreeAxe.GetDisplayName(),
                AttackDamge = random.Next(21, 35),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(8, 12, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelThreeCrossbow.GetDisplayName(),
                AttackDamge = random.Next(14, 21),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(9, 15, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelThreeWand.GetDisplayName(),
                AttackDamge = random.Next(12, 17),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(11, 20, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        public override void GetLevelFourItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFourSword.GetDisplayName(),
                AttackDamge = random.Next(24, 40),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(13, 18, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFourAxe.GetDisplayName(),
                AttackDamge = random.Next(36, 52),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(11, 16, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFourCrossbow.GetDisplayName(),
                AttackDamge = random.Next(17, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(13, 21, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFourWand.GetDisplayName(),
                AttackDamge = random.Next(16, 24),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(21, 30, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }

        public override void GetLevelFiveItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFiveSword.GetDisplayName(),
                AttackDamge = random.Next(36, 54),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(13, 18, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFiveAxe.GetDisplayName(),
                AttackDamge = random.Next(53, 70),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(11, 16, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFiveCrossbow.GetDisplayName(),
                AttackDamge = random.Next(26, 42),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Dexterity)
                    {
                        Values = new AffixValue(20, 29, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = MainHandItems.LevelFiveWand.GetDisplayName(),
                AttackDamge = random.Next(22, 31),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Intelligence)
                    {
                        Values = new AffixValue(32, 44, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
            });
        }
    }

    enum MainHandItems
    {
        [Display(Name = "Copper Sword")] // Level One
        LevelOneSword,
        [Display(Name = "Copper Axe")] // Level One
        LevelOneAxe,
        [Display(Name = "Copper Crossbow")] // Level One
        LevelOneCrossbow,
        [Display(Name = "Copper Wand")] // Level One
        LevelOneWand,

        [Display(Name = "Bronze Sword")] // Level Two
        LevelTwoSword,                                    
        [Display(Name = "Bronze Axe")] // Level Two
        LevelTwoAxe,                                      
        [Display(Name = "Bronze Crossbow")] // Level Two
        LevelTwoCrossbow,                                 
        [Display(Name = "Bronze Wand")] // Level Two
        LevelTwoWand,

        [Display(Name = "Iron Sword")] // Level Three
        LevelThreeSword,
        [Display(Name = "Iron Axe")] // Level Three
        LevelThreeAxe,
        [Display(Name = "Iron Crossbow")] // Level Three
        LevelThreeCrossbow,
        [Display(Name = "Iron Wand")] // Level Three
        LevelThreeWand,

        [Display(Name = "Steel Sword")] // Level Four
        LevelFourSword,
        [Display(Name = "Steel Axe")] // Level Four
        LevelFourAxe,
        [Display(Name = "Steel Crossbow")] // Level Four
        LevelFourCrossbow,
        [Display(Name = "Steel Wand")] // Level Four
        LevelFourWand,

        [Display(Name = "Diamond Sword")] // Level Five
        LevelFiveSword,
        [Display(Name = "Diamond Axe")] // Level Five
        LevelFiveAxe,
        [Display(Name = "Diamond Crossbow")] // Level Five
        LevelFiveCrossbow,
        [Display(Name = "Diamond Wand")] // Level Five
        LevelFiveWand,
    }

}
