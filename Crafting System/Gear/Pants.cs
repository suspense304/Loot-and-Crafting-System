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
    public partial class Pants : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Warbringer's Pantaloons",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Pants,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(18, 34, random),
                    },
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(10, 15, random),
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
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(5, 10, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(1, 100, random),
                    },
                },
            });
        }

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = PantsItems.LevelOneStr.GetDisplayName(),
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
                Name = PantsItems.LevelOneDex.GetDisplayName(),
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
                Name = PantsItems.LevelOneInt.GetDisplayName(),
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

    enum PantsItems
    {
        [Display(Name = "Worn Pants of Power")] // Level One
        LevelOneStr,
        [Display(Name = "Worn Pants of Power")] // Level One
        LevelOneInt,
        [Display(Name = "Worn Pants of Power")] // Level One
        LevelOneDex,
    }
}
