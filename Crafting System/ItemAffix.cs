namespace Crafting_System
{
    public class ItemAffix
    {
        public Affix Affix { get; set; }
        public AffixValue? Values { get; set; }

        public ItemAffix(Affix affix)
        {
            Affix = affix;
        }
    }

    public class AffixValue
    {
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Value { get; set; }
    }

    
}
