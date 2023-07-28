namespace Crafting_System
{
    public class ItemAffix
    {
        public Affix Type { get; private set; }
        public int MinValue { get; private set; }
        public int MaxValue { get; private set; }
        public Affix Affix { get; private set; }

        public ItemAffix(Affix type, int minValue, int maxValue, Affix affix)
        {
            Type = type;
            MinValue = minValue;
            MaxValue = maxValue;
            Affix = affix;
        }
    }

    
}
