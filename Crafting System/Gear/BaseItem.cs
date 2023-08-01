using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System.Gear
{
    public class BaseItem
    {
        public string Name { get; set; }
        public int? AttackDamge { get; set; }
        public int? Armor { get; set; }
        public List<ItemAffix> Affixes { get; set; } = new List<ItemAffix>();
        public int RollWeight { get; set; }
        public LevelBucket LevelBucket { get; set; }
        public int RequiredLevel { get; set; }
    }

    public enum LevelBucket
    {
        One,
        Two,
        Three,
        Four,
        Five,
    }
}
