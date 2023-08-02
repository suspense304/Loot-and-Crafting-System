using System.ComponentModel.DataAnnotations;

namespace Crafting_System
{
    public enum Affix
    {
        [Display(Name = "All Skills")]
        Prefix_AllSkills,

        [Display(Name = "Armor")]
        Prefix_Armor,

        [Display(Name = "Attack Speed")]
        Prefix_AttackSpeed,

        [Display(Name = "Cold Damage")]
        Prefix_ColdDamage,

        [Display(Name = "Fire Skills")]
        Prefix_ColdSkills,

        [Display(Name = "Cooldown Reduction")]
        Prefix_CooldownReduction,

        [Display(Name = "Critical Hit Chance")]
        Prefix_CritChance,

        [Display(Name = "Critical Hit Damage")]
        Prefix_CritDamage,

        [Display(Name = "Dexterity")]
        Prefix_Dexterity,

        [Display(Name = "Fire Damage")]
        Prefix_FireDamage,

        [Display(Name = "Fire Skills")]
        Prefix_FireSkills,

        [Display(Name = "Intelligence")]
        Prefix_Intelligence,

        [Display(Name = "Life")]
        Prefix_Life,

        [Display(Name = "Lightning Damage")]
        Prefix_LightningDamage,

        [Display(Name = "Lightning Skills")]
        Prefix_LightningSkills,

        [Display(Name = "Strength")]
        Prefix_Strength,






        [Display(Name = "Dodge Chance")]
        Suffix_DodgeChance,

        [Display(Name = "Gold Find")]
        Suffix_GoldFind,

        [Display(Name = "Health Regen")]
        Suffix_HealthRegen,

        [Display(Name = "Magic Find")]
        Suffix_MagicFind,

        [Display(Name = "Movement Speed")]
        Suffix_MovementSpeed,

        [Display(Name = "Projectiles")]
        Suffix_Projectiles,

        [Display(Name = "Spell Radius")]
        Suffix_SpellRadius,
    }

}
