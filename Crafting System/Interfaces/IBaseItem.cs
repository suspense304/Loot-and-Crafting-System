using Crafting_System.Gear;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System.Interfaces
{
    public abstract class IBaseItem
    {
        public static List<BaseItem> _baseItems = new List<BaseItem>();
        public static List<EquipmentItem> _legendaryItems = new List<EquipmentItem>();
        public static List<LevelBucket> _buckets = new List<LevelBucket>();

        public virtual void PopulateGear(Random random)
        {
            GetLevelOneItems(random);
            GetLevelTwoItems(random);
            GetLevelThreeItems(random);
            GetLevelFourItems(random);
            GetLevelFiveItems(random);
            _buckets.Add(LevelBucket.One);
            _buckets.Add(LevelBucket.Two);
            _buckets.Add(LevelBucket.Three);
            _buckets.Add(LevelBucket.Four);
            _buckets.Add(LevelBucket.Five);
            PopulateLegendaryItems(random);
        }

        public virtual void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {

        }

        public virtual BaseItem GetBaseItem(int level, Random random, Rarity rarity, int maxBucket)
        {
            int itemLevel = random.Next(level - 3, level + 3);

            BaseItem value = itemLevel switch
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

        public virtual BaseItem GetRandomBaseItem(int maxBucket, Random random)
        {
            LevelBucket bucket = _buckets[random.Next(0, maxBucket)];

            List<BaseItem> weight = _baseItems.Where(w => w.LevelBucket == bucket).ToList();
            var roll = random.Next(0, _baseItems.Where(w => w.LevelBucket == bucket).Sum(s => s.RollWeight));

            for(int i = 0; i < _baseItems.Count; i++)
            {
                roll -= _baseItems[i].RollWeight;

                if(roll <= 0)
                {
                    return weight[i];
                }
            }
            return weight[0];
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
            return _legendaryItems;
        }
    }
}
