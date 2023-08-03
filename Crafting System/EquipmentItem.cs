namespace Crafting_System
{
    public class EquipmentItem
    {
        public string Name { get; set; } = string.Empty;

        public int? AttackDamage { get; set; }

        public int? Armor { get; set; }

        public Rarity Rarity { get; set; }

        public GearSlot Slot { get; set; }

        public List<ItemAffix> BaseAffixes { get; set; }

        public List<ItemAffix> Prefixes { get; set; }

        public List<ItemAffix> Suffixes { get; set; }

        public int RequiredLevel { get; set; }

        public int MaxAffix => GetMaxAffix();

        private const int MaxAffixesPerType = 3;

        public EquipmentItem()
        {
            Name = string.Empty;
            Rarity = Rarity.Normal;
            Slot = GearSlot.Chest;
            Prefixes = new List<ItemAffix>();
            Suffixes = new List<ItemAffix>();
        }

        public bool AddAffix(ItemAffix affix, AffixType affixType)
        {
            List<ItemAffix> affixList = affixType == AffixType.Prefix ? Prefixes : Suffixes;

            if (affixList.Count < MaxAffixesPerType)
            {
                affixList.Add(affix);
                return true;
            }

            return false;
        }

        int GetMaxAffix()
        {
            switch(Rarity)
            {
                case Rarity.Normal: return 0;
                case Rarity.Magic: return 2;
                case Rarity.Rare: return 3;
                case Rarity.Epic: return 4;
                case Rarity.Legendary: return 5;
                case Rarity.Super: return 6;
            }

            return 0;
        }
    }

    public class WeaponItem : EquipmentItem
    {
        public WeaponType Weapon { get; set; }
    }

    
}
