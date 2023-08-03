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
    public class OffHandItem : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Last Stand",
                Armor = 550,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
                BaseAffixes = new List<ItemAffix>(),
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_Strength)
                    {
                        Values = new AffixValue(70, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_Life)
                    {
                        Values = new AffixValue(125, 250, random),
                    },
                },
                Suffixes = new List<ItemAffix>(),
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Twisted Evil",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
                BaseAffixes = new List<ItemAffix>(),
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_LightningDamage)
                    {
                        Values = new AffixValue(125, 250, random),
                    },
                    new ItemAffix(Affix.Prefix_LightningSkills)
                    {
                        Values = new AffixValue(1, 4, random),
                    },
                },
                Suffixes = new List<ItemAffix>(),
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Enoch's Quiver",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
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
                Name = OffhandItems.LevelOneShield.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = OffhandItems.LevelOneTome.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = OffhandItems.LevelOneQuiver.GetDisplayName(),
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
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = OffhandItems.LevelTwoShield.GetDisplayName(),
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
                Name = OffhandItems.LevelTwoQuiver.GetDisplayName(),
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
                Name = OffhandItems.LevelTwoTome.GetDisplayName(),
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
                Name = OffhandItems.LevelThreeShield.GetDisplayName(),
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
                Name = OffhandItems.LevelThreeQuiver.GetDisplayName(),
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
                Name = OffhandItems.LevelThreeTome.GetDisplayName(),
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
                Name = OffhandItems.LevelFourShield.GetDisplayName(),
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
                Name = OffhandItems.LevelFourQuiver.GetDisplayName(),
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
                Name = OffhandItems.LevelFourTome.GetDisplayName(),
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
                Name = OffhandItems.LevelFiveShield.GetDisplayName(),
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
                Name = OffhandItems.LevelFiveQuiver.GetDisplayName(),
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
                Name = OffhandItems.LevelFiveTome.GetDisplayName(),
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

    enum OffhandItems
    {
        [Display(Name = "Worn Shield")] // Level One
        LevelOneShield,
        [Display(Name = "Worn Quiver")] // Level One
        LevelOneQuiver,
        [Display(Name = "Worn Tome")] // Level One
        LevelOneTome,

        [Display(Name = "Wooden Shield")] // Level Two
        LevelTwoShield,
        [Display(Name = "Wooden Quiver")] // Level Two
        LevelTwoQuiver,
        [Display(Name = "Wooden Tome")] // Level Two
        LevelTwoTome,

        [Display(Name = "Leather Shield")] // Level Three
        LevelThreeShield,
        [Display(Name = "Leather Quiver")] // Level Three
        LevelThreeQuiver,
        [Display(Name = "Leather Tome")] // Level Three
        LevelThreeTome,

        [Display(Name = "Iron Shield")] // Level Four
        LevelFourShield,
        [Display(Name = "Iron Quiver")] // Level Four
        LevelFourQuiver,
        [Display(Name = "Iron Tome")] // Level Four
        LevelFourTome,

        [Display(Name = "Diamond Shield")] // Level Five
        LevelFiveShield,
        [Display(Name = "Diamond Quiver")] // Level Five
        LevelFiveQuiver,
        [Display(Name = "Diamond Tome")] // Level Five
        LevelFiveTome,
    }
}
