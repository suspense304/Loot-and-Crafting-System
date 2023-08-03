using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Crafting_System
{
    public class AffixCreator
    {
        public AffixValue RollAllSkills(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 1, random),
                float i when i >= 30 && i < 55 => new AffixValue(1, 2, random),
                float i when i >= 55 => new AffixValue(1, 3, random),
                _ => new AffixValue(1, 1, random)
            };

            return value;
        }

        public AffixValue RollArmor(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(4, 12, random),
                float i when i >= 10 && i < 20 => new AffixValue(8, 18, random),
                float i when i >= 20 && i < 30 => new AffixValue(12, 24, random),
                float i when i >= 30 && i < 40 => new AffixValue(16, 30, random),
                float i when i >= 40 && i < 50 => new AffixValue(20, 36, random),
                float i when i >= 50 && i < 60 => new AffixValue(24, 42, random),
                float i when i >= 60 && i < 70 => new AffixValue(28, 48, random),
                float i when i >= 70 => new AffixValue(32, 54, random),
                _ => new AffixValue(4, 12, random)
            };

            return value;
        }

        public AffixValue RollAttackSpeed(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(5, 8, random),
                float i when i >= 10 && i < 30 => new AffixValue(7, 13, random),
                float i when i >= 30 && i < 45 => new AffixValue(11, 17, random),
                float i when i >= 55 && i < 70 => new AffixValue(15, 20, random),
                float i when i >= 70 => new AffixValue(18, 25, random),
                _ => new AffixValue(5, 8, random)
            };

            return value;
        }

        public AffixValue RollCooldownReduction(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 7, random),
                float i when i >= 30 && i < 55 => new AffixValue(5, 11, random),
                float i when i >= 55 => new AffixValue(9, 15, random),
                _ => new AffixValue(5, 8, random)
            };

            return value;
        }

        public AffixValue RollCritChance(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 7, random),
                float i when i >= 30 && i < 55 => new AffixValue(5, 11, random),
                float i when i >= 55 => new AffixValue(9, 15, random),
                _ => new AffixValue(5, 8, random)
            };

            return value;
        }

        public AffixValue RollCritDamage(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(5, 10, random),
                float i when i >= 10 && i < 30 => new AffixValue(7, 20, random),
                float i when i >= 30 && i < 45 => new AffixValue(15, 27, random),
                float i when i >= 55 && i < 70 => new AffixValue(24, 35, random),
                float i when i >= 70 => new AffixValue(32, 50, random),
                _ => new AffixValue(5, 8, random)
            };

            return value;

        }

        public AffixValue RollColdDamage(float level, Random random) 
        {
            return RollDamageIncrease(level, random);
        }

        public AffixValue RollFireDamage(float level, Random random) 
        {
            return RollDamageIncrease(level, random);
        }

        public AffixValue RollLightningDamage(float level, Random random) 
        {
            return RollDamageIncrease(level, random);
        }

        public AffixValue RollLife(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(4, 7, random),
                float i when i >= 10 && i < 20 => new AffixValue(8, 13, random),
                float i when i >= 20 && i < 30 => new AffixValue(17, 24, random),
                float i when i >= 30 && i < 40 => new AffixValue(31, 42, random),
                float i when i >= 40 && i < 50 => new AffixValue(47, 66, random),
                float i when i >= 50 && i < 60 => new AffixValue(70, 93, random),
                float i when i >= 60 && i < 70 => new AffixValue(105, 130, random),
                float i when i >= 70 => new AffixValue(134, 175, random),
                _ => new AffixValue(4, 12, random)
            };

            return value;
        }

        public AffixValue RollDexterity(float level, Random random) 
        {
            return RollBaseStat(level, random);
        }

        public AffixValue RollDodgeChance(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 7, random),
                float i when i >= 30 && i < 55 => new AffixValue(5, 11, random),
                float i when i >= 55 => new AffixValue(9, 15, random),
                _ => new AffixValue(5, 8, random)
            };

            return value;
        }

        public AffixValue RollGoldFind(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(10, 15, random),
                float i when i >= 30 && i < 55 => new AffixValue(10, 20, random),
                float i when i >= 55 => new AffixValue(10, 25, random),
                _ => new AffixValue(10, 15, random)
            };

            return value;
        }

        public AffixValue RollHealthRegen(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 2, random),
                float i when i >= 30 && i < 55 => new AffixValue(1, 4, random),
                float i when i >= 55 => new AffixValue(2, 5, random),
                _ => new AffixValue(1, 2, random)
            };

            return value;
        }

        public AffixValue RollIntelligence(float level, Random random) 
        {
            return RollBaseStat(level, random);
        }

        public AffixValue RollMagicFind(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(10, 15, random),
                float i when i >= 30 && i < 55 => new AffixValue(10, 20, random),
                float i when i >= 55 => new AffixValue(10, 25, random),
                _ => new AffixValue(10, 15, random)
            };

            return value;
        }

        public AffixValue RollMovementSpeed(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(10, 15, random),
                float i when i >= 30 && i < 55 => new AffixValue(10, 20, random),
                float i when i >= 55 => new AffixValue(10, 25, random),
                _ => new AffixValue(10, 15, random)
            };

            return value;
        }

        public AffixValue RollProjectiles(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(1, 2, random),
                float i when i >= 30 && i < 55 => new AffixValue(1, 3, random),
                float i when i >= 55 => new AffixValue(1, 4, random),
                _ => new AffixValue(1, 2, random)
            };

            return value;
        }

        public AffixValue RollSpellRadius(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 30 => new AffixValue(5, 10, random),
                float i when i >= 30 && i < 55 => new AffixValue(9, 15, random),
                float i when i >= 55 => new AffixValue(13, 25, random),
                _ => new AffixValue(5, 10, random)
            };

            return value;
        }

        public AffixValue RollStrength(float level, Random random) 
        {
            return RollBaseStat(level, random);
        }

        public AffixValue RollBaseStat(float level, Random random) 
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(1, 6, random),
                float i when i >= 10 && i < 20 => new AffixValue(4, 11, random),
                float i when i >= 20 && i < 30 => new AffixValue(7, 16, random),
                float i when i >= 30 && i < 40 => new AffixValue(10, 21, random),
                float i when i >= 40 && i < 50 => new AffixValue(13, 26, random),
                float i when i >= 50 && i < 60 => new AffixValue(16, 31, random),
                float i when i >= 60 && i < 70 => new AffixValue(19, 36, random),
                float i when i >= 70 => new AffixValue(22, 41, random),
                _ => new AffixValue(1, 6, random)
            };
            return value;
        }

        public AffixValue RollDamageIncrease(float level, Random random)
        {
            AffixValue value = level switch
            {
                float i when i < 10 => new AffixValue(2, 5, random),
                float i when i >= 10 && i < 20 => new AffixValue(3, 11, random),
                float i when i >= 20 && i < 30 => new AffixValue(7, 22, random),
                float i when i >= 30 && i < 40 => new AffixValue(11, 33, random),
                float i when i >= 40 && i < 50 => new AffixValue(22, 44, random),
                float i when i >= 50 && i < 60 => new AffixValue(33, 55, random),
                float i when i >= 60 && i < 70 => new AffixValue(44, 66, random),
                float i when i >= 70 => new AffixValue(55, 77, random),
                _ => new AffixValue(2, 5, random)
            };
            return value;
        }

    }
}
