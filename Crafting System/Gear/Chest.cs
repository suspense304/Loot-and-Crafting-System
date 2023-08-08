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
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
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
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(10, 15, random),
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

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ChestItems.LevelOneStr.GetDisplayName(),
                Armor = random.Next(4, 10),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
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
                Name = ChestItems.LevelOneDex.GetDisplayName(),
                Armor = random.Next(3, 6),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_SpellDamage)
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
                Name = ChestItems.LevelOneInt.GetDisplayName(),
                Armor = random.Next(1, 4),
                Affixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(1, 3, random),
                    },
                },
                RollWeight = 400,
                LevelBucket = LevelBucket.One,
                RequiredLevel = 3,
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
    }
}
