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
                    new ItemAffix(Affix.Prefix_SpellDamage)
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
                    new ItemAffix(Affix.Prefix_AttackRadius)
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
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(30, 75, random),
                    },
                    new ItemAffix(Affix.Prefix_AttackRadius)
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
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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
                    new ItemAffix(Affix.Prefix_AttackRadius)
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
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(50, 65, random),
                    },
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
                    {
                        Values = new AffixValue(2, 4, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
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
                            new ItemAffix(Affix.Prefix_AttackSpeed),
                            new ItemAffix(Affix.Prefix_SpellDamage),
                            new ItemAffix(Affix.Prefix_PhysicalDamage),
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
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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
                    new ItemAffix(Affix.Prefix_SpellDamage)
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
                    new ItemAffix(Affix.Prefix_AttackSpeed)
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
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(3, 6, random),
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
    }

}
