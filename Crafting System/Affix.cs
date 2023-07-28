using System.ComponentModel.DataAnnotations;

namespace Crafting_System
{
    public enum Affix
    {
        [Display(Name = "Armor")]
        Armor,
        [Display(Name = "Attack Speed")]
        AttackSpeed,
        [Display(Name = "Critical Hit Chance")]
        CritChance,
        [Display(Name = "Critical Hit Damage")]
        CritDamage,
        [Display(Name = "Dexterity")]
        Dexterity,
        [Display(Name = "Dodge Chance")]
        DodgeChance,
        [Display(Name = "Gold Find")]
        GoldFind,
        [Display(Name = "Health Regen")]
        HealthRegen,
        [Display(Name = "Intelligence")]
        Intelligence,
        [Display(Name = "Attack Speed")]
        MagicFind,
        [Display(Name = "Movement Speed")]
        MovementSpeed,
        [Display(Name = "Projectiles")]
        Projectiles,
        [Display(Name = "Spell Radius")]
        SpellRadius,
        [Display(Name = "Strength")]
        Strength,
        [Display(Name = "Willpower")]
        Willpower,
    }

}
