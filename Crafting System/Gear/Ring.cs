using Crafting_System.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Crafting_System.Gear
{
    public partial class Ring : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Elemental Chaos",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Amulet,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CooldownReduction)
                    {
                        Values = new AffixValue(1, 30, random),
                    },
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(1, 30, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_ColdDamage)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_FireDamage)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_LightningDamage)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                    new ItemAffix(Affix.Suffix_Projectiles)
                    {
                        Values = new AffixValue(1, 5, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                },
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Physical Chaos",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Amulet,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(1, 25, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(1, 200, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(1, 50, random),
                    },
                    new ItemAffix(Affix.Prefix_CooldownReduction)
                    {
                        Values = new AffixValue(1, 30, random),
                    },
                    new ItemAffix(Affix.Prefix_AllSkills)
                    {
                        Values = new AffixValue(1, 5, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_GoldFind)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                    new ItemAffix(Affix.Suffix_Projectiles)
                    {
                        Values = new AffixValue(1, 5, random),
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
                            new ItemAffix(Affix.Suffix_MovementSpeed),
                            new ItemAffix(Affix.Suffix_SpellRadius),
                        });
        }

        public override void GetLevelTwoItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = RingItems.LevelTwoStr.GetDisplayName(),
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
                Name = RingItems.LevelTwoDex.GetDisplayName(),
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
                Name = RingItems.LevelTwoInt.GetDisplayName(),
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
                Name = RingItems.LevelThreeStr.GetDisplayName(),
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
                Name = RingItems.LevelThreeDex.GetDisplayName(),
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
                Name = RingItems.LevelThreeInt.GetDisplayName(),
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
                Name = RingItems.LevelFourStr.GetDisplayName(),
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
                Name = RingItems.LevelFourDex.GetDisplayName(),
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
                Name = RingItems.LevelFourInt.GetDisplayName(),
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
                Name = RingItems.LevelFiveStr.GetDisplayName(),
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
                Name = RingItems.LevelFiveDex.GetDisplayName(),
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
                Name = RingItems.LevelFiveInt.GetDisplayName(),
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
    enum RingItems
    {
        [Display(Name = "Silver Amulet of Power")] // Level Two
        LevelTwoStr,
        [Display(Name = "Silver Amulet of Wisdom")] // Level Two
        LevelTwoInt,
        [Display(Name = "Silver Amulet of Speed")] // Level Two
        LevelTwoDex,

        [Display(Name = "Silver Amulet of Power")] // Level Three
        LevelThreeStr,
        [Display(Name = "Silver Amulet of Wisdom")] // Level Three
        LevelThreeInt,
        [Display(Name = "Silver Amulet of Speed")] // Level Three
        LevelThreeDex,

        [Display(Name = "Gold Amulet of Power")] // Level Four
        LevelFourStr,
        [Display(Name = "Gold Amulet of Wisdom")] // Level Four
        LevelFourInt,
        [Display(Name = "Gold Amulet of Speed")] // Level Four
        LevelFourDex,

        [Display(Name = "Diamond Amulet of Power")] // Level Five
        LevelFiveStr,
        [Display(Name = "Diamond Amulet of Wisdom")] // Level Five
        LevelFiveInt,
        [Display(Name = "Diamond Amulet of Speed")] // Level Five
        LevelFiveDex,
    }
}