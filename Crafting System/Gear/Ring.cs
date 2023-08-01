using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System.Gear
{
    public class Ring
    {
        public static void GetAffixes(AffixType affixType, List<ItemAffix> affixes)
        {
            affixes.AddRange(affixType == AffixType.Prefix
                        ? new[] {
                            new ItemAffix(Affix.AttackSpeed),
                            new ItemAffix(Affix.CritChance),
                            new ItemAffix(Affix.CritDamage),
                            new ItemAffix(Affix.Dexterity),
                            new ItemAffix(Affix.Intelligence),
                            new ItemAffix(Affix.Strength),
                        }
                        : new[] {
                            new ItemAffix(Affix.DodgeChance),
                            new ItemAffix(Affix.GoldFind),
                            new ItemAffix(Affix.HealthRegen),
                            new ItemAffix(Affix.MagicFind),
                            new ItemAffix(Affix.MovementSpeed),
                            new ItemAffix(Affix.SpellRadius),
                        });
        }
    }
}
