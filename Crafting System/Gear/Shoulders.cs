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
                Prefixes = new List<ItemAffix>(),
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

        public override void GetLevelTwoItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = ShoulderItems.LevelTwoStr.GetDisplayName(),
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
                Name = ShoulderItems.LevelTwoDex.GetDisplayName(),
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
                Name = ShoulderItems.LevelTwoInt.GetDisplayName(),
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

    enum ShoulderItems
    {

        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoStr,
        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoInt,
        [Display(Name = "Cloth Shoulders of Power")] // Level Two
        LevelTwoDex,
    }
}
