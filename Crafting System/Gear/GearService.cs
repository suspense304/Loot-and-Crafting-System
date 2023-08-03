using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System.Gear
{
    public class GearService
    {
        static Dictionary<GearSlot, List<ItemAffix>> _gearSlotPrefixPools = new Dictionary<GearSlot, List<ItemAffix>>();
        static Dictionary<GearSlot, List<ItemAffix>> _gearSlotSuffixPools = new Dictionary<GearSlot, List<ItemAffix>>();
        static Dictionary<GearSlot, int> _gearSlotWeights = new Dictionary<GearSlot, int>();

        public GearService()
        {
            CreateGearSlotAffixPools();
            GetGearSlotWeights();
        }

        public static void GetGearSlotWeights()
        {

        }

        public static Dictionary<GearSlot, List<ItemAffix>> GetSlotPrefixes()
        {
            return _gearSlotPrefixPools;
        }

        public static Dictionary<GearSlot, List<ItemAffix>> GetSlotSuffixes()
        {
            return _gearSlotSuffixPools;
        }

        public GearSlot GetRandomGearSlot(Random random)
        {
            Array gearSlots = Enum.GetValues(typeof(GearSlot));
            int randomIndex = random.Next(0, gearSlots.Length);
            return (GearSlot)gearSlots.GetValue(randomIndex);
        }
        public void CreateGearSlotAffixPools()
        {
            foreach (GearSlot slot in Enum.GetValues(typeof(GearSlot)))
            {
                List<ItemAffix> prefixesForSlot = GetAffixesForSlot(slot, AffixType.Prefix);
                List<ItemAffix> suffixesForSlot = GetAffixesForSlot(slot, AffixType.Suffix);

                _gearSlotPrefixPools.Add(slot, prefixesForSlot);
                _gearSlotSuffixPools.Add(slot, suffixesForSlot);
            }
        }
        private List<ItemAffix> GetAffixesForSlot(GearSlot slot, AffixType affixType)
        {
            List<ItemAffix> affixes = new List<ItemAffix>();

            // Add the appropriate affixes for each GearSlot and AffixType
            switch (slot)
            {
                case GearSlot.Head:
                    new Head().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Shoulders:
                    new Shoulders().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Chest:
                    new Chest().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Gloves:
                    new Gloves().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Belt:
                    new Belt().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Pants:
                    new Pants().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Boots:
                    new Boots().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Ring:
                    new Ring().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.Amulet:
                    new Amulet().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.MainHand:
                    new MainHand().GetAffixes(affixType, affixes);
                    break;
                case GearSlot.OffHand:
                    new OffHandItem().GetAffixes(affixType, affixes);
                    break;
                default:
                    break;
            }

            return affixes;
        }
    }
}
