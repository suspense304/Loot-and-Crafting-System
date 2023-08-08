using Crafting_System.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Crafting_System.Gear
{  public class Belt : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Restricted",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.Belt,
                BaseAffixes = new List<ItemAffix>(),
                Prefixes = new List<ItemAffix>(),
                Suffixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Suffix_HealthRegen)
                    {
                        Values = new AffixValue(5, 15, random),
                    },
                },
            });
        }

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = BeltItems.LevelOneStr.GetDisplayName(),
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
                Name = BeltItems.LevelOneDex.GetDisplayName(),
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
                Name = BeltItems.LevelOneInt.GetDisplayName(),
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

    enum BeltItems
    {
        [Display(Name = "Worn Belt of Power")] // Level One
        LevelOneStr,
        [Display(Name = "Worn Belt of Wisdom")] // Level One
        LevelOneInt,
        [Display(Name = "Worn Belt of Speed")] // Level One
        LevelOneDex,
    }
}
