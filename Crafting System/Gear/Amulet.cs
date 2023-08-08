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
    public partial class Amulet : IBaseItem
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

        public override void GetLevelThreeItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = AmuletItems.LevelThreeStr.GetDisplayName(),
                Armor = random.Next(28, 45),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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
                Name = AmuletItems.LevelThreeDex.GetDisplayName(),
                Armor = random.Next(24, 37),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
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
                Name = AmuletItems.LevelThreeInt.GetDisplayName(),
                Armor = random.Next(21, 30),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(7, 12, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.Three,
                RequiredLevel = 26,
            });
        }
    }

    enum AmuletItems
    {
        [Display(Name = "Silver Amulet of Power")] // Level Three
        LevelThreeStr,
        [Display(Name = "Silver Amulet of Wisdom")] // Level Three
        LevelThreeInt,
        [Display(Name = "Silver Amulet of Speed")] // Level Three
        LevelThreeDex,
    }
}

