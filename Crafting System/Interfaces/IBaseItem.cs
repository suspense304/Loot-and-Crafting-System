﻿using Crafting_System.Gear;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System.Interfaces
{
    public abstract class IBaseItem
    {
        public static List<LevelBucket> _buckets = new List<LevelBucket>();

        public virtual void PopulateGear(Random random)
        {
            _buckets.Add(LevelBucket.One);
            _buckets.Add(LevelBucket.Two);
            _buckets.Add(LevelBucket.Three);
            _buckets.Add(LevelBucket.Four);
            _buckets.Add(LevelBucket.Five);
            GetLevelOneItems(random);
            GetLevelTwoItems(random);
            GetLevelThreeItems(random);
            GetLevelFourItems(random);
            GetLevelFiveItems(random);
            PopulateLegendaryItems(random);
        }

        public virtual void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.Prefix_Armor),
                            new ItemAffix(Affix.Prefix_AttackRadius),
                            new ItemAffix(Affix.Prefix_AttackSpeed),
                            new ItemAffix(Affix.Prefix_CooldownReduction),
                            new ItemAffix(Affix.Prefix_CritChance),
                            new ItemAffix(Affix.Prefix_CritDamage),
                            new ItemAffix(Affix.Prefix_Life),
                            new ItemAffix(Affix.Prefix_PhysicalDamage),
                            new ItemAffix(Affix.Prefix_SpellDamage),
                        }
                        : new[] {
                            new ItemAffix(Affix.Suffix_DodgeChance),
                            new ItemAffix(Affix.Suffix_ExperienceGain),
                            new ItemAffix(Affix.Suffix_GoldFind),
                            new ItemAffix(Affix.Suffix_HealthRegen),
                            new ItemAffix(Affix.Suffix_MagicFind),
                            new ItemAffix(Affix.Suffix_MobDensity),
                            new ItemAffix(Affix.Suffix_MovementSpeed),
                            new ItemAffix(Affix.Suffix_PickupRadius),
                            new ItemAffix(Affix.Suffix_Projectiles),
                            new ItemAffix(Affix.Suffix_ProjectileSpeed),
                            new ItemAffix(Affix.Suffix_SpellDuration),
                            new ItemAffix(Affix.Suffix_SpellRadius),
                        });
        }

        public virtual BaseItem? GetBaseItem(int level, Random random, Rarity rarity, int maxBucket)
        {
            
            int itemLevel = random.Next(level - 3, level + 3);

            BaseItem? value = itemLevel switch
            {
                int i when i < 13 => GetRandomBaseItem(maxBucket, random),
                int i when i >= 13 && i < 26 => GetRandomBaseItem(maxBucket, random),
                int i when i >= 26 && i < 39 => GetRandomBaseItem(maxBucket, random),
                int i when i >= 39 && i < 55 => GetRandomBaseItem(maxBucket, random),
                int i when i >= 55 => GetRandomBaseItem(maxBucket, random),
                _ => GetRandomBaseItem(maxBucket, random),
            };

            return value;
        }

        public virtual BaseItem? GetRandomBaseItem(int maxBucket, Random random)
        {
            LevelBucket bucket = _buckets[random.Next(0, maxBucket)];

            List<BaseItem> items = ItemCreationService.BaseItems.Where(w => w.LevelBucket == bucket).ToList();

            if(items.Count == 0) return null;

            var roll = random.Next(0, ItemCreationService.BaseItems.Where(w => w.LevelBucket == bucket).Sum(s => s.RollWeight));

            for(int i = 0; i < ItemCreationService.BaseItems.Count; i++)
            {
                roll -= ItemCreationService.BaseItems[i].RollWeight;

                if(roll <= 0)
                {
                    return items[i];
                }
            }

            return null;
        }

        public virtual void GetLevelOneItems(Random random)
        {

        }

        public virtual void GetLevelTwoItems(Random random)
        {

        }

        public virtual void GetLevelThreeItems(Random random)
        {

        }

        public virtual void GetLevelFourItems(Random random)
        {

        }

        public virtual void GetLevelFiveItems(Random random)
        {

        }
        public virtual void PopulateLegendaryItems(Random random)
        {

        }
        public List<EquipmentItem> GetLegendaryItems()
        {
            return ItemCreationService.LegendaryItems;
        }
    }
}
