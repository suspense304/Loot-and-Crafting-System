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
                    new ItemAffix(Affix.Prefix_SpellDamage)
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
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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

        public override void GetLevelTwoItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = RingItems.LevelTwoStr.GetDisplayName(),
                Armor = random.Next(18, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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
                    new ItemAffix(Affix.Prefix_AttackSpeed)
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
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(4, 7, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Two,
                RequiredLevel = 13,
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
    }
}