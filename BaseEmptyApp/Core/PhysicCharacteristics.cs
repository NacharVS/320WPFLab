using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class PhysicCharacteristics
    {
        public static double PhysicAttack(int Strength, int Dexterity)
        {
            return Strength * 3 + Dexterity * 3;
        }

        public static double PhysicDefense(int Constitution, int Dexterity)
        {
            return Constitution * 0.5 + Dexterity * 3;
        }

        public static double PhysicCriticalChanse(int Dexterity)
        {
            return 20 + Dexterity * 0.3;
        }

        public static double PhysicCriticalDamage(double PhysicAttackDouble, int Dexterity)
        {
            return PhysicAttackDouble * (2 + Dexterity * 0.05);
        }
    }
}