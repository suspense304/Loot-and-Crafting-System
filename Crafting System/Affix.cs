using System.ComponentModel.DataAnnotations;

namespace Crafting_System
{
    public enum Affix
    {
        // Prefixes 

        [Display(Name = "Armor")]
        Prefix_Armor,

        [Display(Name = "Attack Radius")]
        Prefix_AttackRadius,

        [Display(Name = "Attack Speed")]
        Prefix_AttackSpeed,

        [Display(Name = "Cooldown Reduction")]
        Prefix_CooldownReduction,

        [Display(Name = "Critical Hit Chance")]
        Prefix_CritChance,

        [Display(Name = "Critical Hit Damage")]
        Prefix_CritDamage,

        [Display(Name = "Life")]
        Prefix_Life,

        [Display(Name = "Physical Damage")]
        Prefix_PhysicalDamage,

        [Display(Name = "Spell Damage")]
        Prefix_SpellDamage,


        // Suffixes

        [Display(Name = "Dodge Chance")]
        Suffix_DodgeChance,

        [Display(Name = "Experience Gain")]
        Suffix_ExperienceGain,

        [Display(Name = "Gold Find")]
        Suffix_GoldFind,

        [Display(Name = "Health Regen")]
        Suffix_HealthRegen,

        [Display(Name = "Magic Find")]
        Suffix_MagicFind,

        [Display(Name = "Mob Density")]
        Suffix_MobDensity,

        [Display(Name = "Movement Speed")]
        Suffix_MovementSpeed,

        [Display(Name = "Pickup Radius")]
        Suffix_PickupRadius,

        [Display(Name = "Projectiles")]
        Suffix_Projectiles,

        [Display(Name = "Projectile Speed")]
        Suffix_ProjectileSpeed,

        [Display(Name = "Spell Duration")]
        Suffix_SpellDuration,

        [Display(Name = "Spell Radius")]
        Suffix_SpellRadius,
    }

}
