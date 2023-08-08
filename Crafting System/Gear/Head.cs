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
    public partial class Head : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Kalen's Crown",
                Armor = 188,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Head,
                BaseAffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_CritChance)
                    {
                        Values = new AffixValue(10, 20, random),
                    },
                    new ItemAffix(Affix.Prefix_CritDamage)
                    {
                        Values = new AffixValue(50, 100, random),
                    },
                },
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_AttackSpeed)
                    {
                        Values = new AffixValue(84, 125, random),
                    },
                    new ItemAffix(Affix.Suffix_Projectiles)
                    {
                        Values = new AffixValue(3, 5, random),
                    },
                },
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_MovementSpeed)
                    {
                        Values = new AffixValue(20, 30, random),
                    },
                    new ItemAffix(Affix.Suffix_DodgeChance)
                    {
                        Values = new AffixValue(10, 15, random),
                    },
                    new ItemAffix(Affix.Suffix_MagicFind)
                    {
                        Values = new AffixValue(20, 25, random),
                    },
                },
            });
        }

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = HeadItems.LevelOneStr.GetDisplayName(),
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
                Name = HeadItems.LevelOneDex.GetDisplayName(),
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
                Name = HeadItems.LevelOneInt.GetDisplayName(),
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

    enum HeadItems
    {
        [Display(Name = "Torn Helm")] // Level One
        LevelOneStr,
        [Display(Name = "Crown of Despair")] // Level One
        LevelOneInt,
        [Display(Name = "Helm of Torment")] // Level One
        LevelOneDex,
    }
}
