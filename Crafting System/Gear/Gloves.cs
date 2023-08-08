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
    public partial class Gloves : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Callen's Gloves",
                Armor = 60,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Gloves,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(1, 30, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(10, 20, random),
                    },
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(30, 75, random),
                    },
                    new ItemAffix(Affix.Prefix_AttackRadius)
                    {
                        Values = new AffixValue(1, 3, random),
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

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = GloveItems.LevelOneStr.GetDisplayName(),
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
                Name = GloveItems.LevelOneDex.GetDisplayName(),
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
                Name = GloveItems.LevelOneInt.GetDisplayName(),
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

    enum GloveItems
    {
        [Display(Name = "Worn Gloves of Power")] // Level One
        LevelOneStr,
        [Display(Name = "Worn Gloves of Wisdom")] // Level One
        LevelOneInt,
        [Display(Name = "Worn Gloves of Speed")] // Level One
        LevelOneDex,
    }
}
