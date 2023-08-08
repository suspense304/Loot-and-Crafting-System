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
    public class OffHandItem : IBaseItem
    {
        public override void PopulateLegendaryItems(Random random)
        {
            random.Next();
            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Last Stand",
                Armor = 550,
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
                BaseAffixes = new List<ItemAffix>(),
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_PhysicalDamage)
                    {
                        Values = new AffixValue(70, 100, random),
                    },
                    new ItemAffix(Affix.Prefix_Life)
                    {
                        Values = new AffixValue(125, 250, random),
                    },
                },
                Suffixes = new List<ItemAffix>(),
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Twisted Evil",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
                BaseAffixes = new List<ItemAffix>(),
                Prefixes = new List<ItemAffix>
                {
                    new ItemAffix(Affix.Prefix_SpellDamage)
                    {
                        Values = new AffixValue(125, 250, random),
                    },
                    new ItemAffix(Affix.Prefix_AttackRadius)
                    {
                        Values = new AffixValue(1, 4, random),
                    },
                },
                Suffixes = new List<ItemAffix>(),
            });

            ItemCreationService.LegendaryItems.Add(new EquipmentItem
            {
                Name = "Enoch's Quiver",
                Rarity = Rarity.Legendary,
                RequiredLevel = 55,
                Slot = GearSlot.OffHand,
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
        }

        public override void GetLevelOneItems(Random random)
        {
            ItemCreationService.BaseItems.Add(new BaseItem
            {
                Name = OffhandItems.LevelOneShield.GetDisplayName(),
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
                Name = OffhandItems.LevelOneTome.GetDisplayName(),
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
                Name = OffhandItems.LevelOneQuiver.GetDisplayName(),
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

    enum OffhandItems
    {
        [Display(Name = "Worn Shield")] // Level One
        LevelOneShield,
        [Display(Name = "Worn Quiver")] // Level One
        LevelOneQuiver,
        [Display(Name = "Worn Tome")] // Level One
        LevelOneTome,
    }
}
