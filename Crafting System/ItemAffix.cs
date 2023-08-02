using System;

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

        public List<Affix> Affixes(List<Affix> affixes, int level)
        {
            foreach(var affix in affixes)
            {
                new ItemAffix(affix)
                {
                    Values = new ItemCreationService().GetAffixValue(affix, level)
                };
            }

            return affixes;
        }

    }

    public class AffixValue
    {
        public float MinValue { get; set; }
        public float MaxValue { get; set; }
        public float Value { get; set; }

        public AffixValue(float minValue, float maxValue, Random random)
        {
            MinValue = minValue;
            MaxValue = maxValue;
            Value = random.Next((int)MinValue, (int)MaxValue);
        }
    }


}
