namespace Crafting_System
{
    public class BattleStats
    {
        public Dictionary<Affix, int> Stats = new Dictionary<Affix, int>();

        public BattleStats() 
        {
            Stats.Add(Affix.Armor, 0);
            Stats.Add(Affix.AttackSpeed, 0);
            Stats.Add(Affix.CritChance, 0);
            Stats.Add(Affix.CritDamage, 0);
            Stats.Add(Affix.Dexterity, 0);
            Stats.Add(Affix.DodgeChance, 0);
            Stats.Add(Affix.GoldFind, 0);
            Stats.Add(Affix.HealthRegen, 0);
            Stats.Add(Affix.Intelligence, 0);
            Stats.Add(Affix.MagicFind, 0);
            Stats.Add(Affix.MovementSpeed, 0);
            Stats.Add(Affix.Projectiles, 0);
            Stats.Add(Affix.SpellRadius, 0);
            Stats.Add(Affix.Strength, 0);
        }

        

    }

    
}
