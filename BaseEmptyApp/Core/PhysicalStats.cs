using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class PhysicalStats
    {
        public double PhysAttack(int Strength, int Dexterity)
        {
            return Strength * 3 + Dexterity * 3;
        }

        public double PhysDefense(int Constitution, int Dexterity)
        {
            return Constitution * 0.5 + Dexterity * 3;
        }

        public double PhysCriticalDamage(int Dexterity)
        {
            return 20 + Dexterity * 0.3;
        }

        public double PhysCriticalDamage(double PhysAttackDouble, int Dexterity)
        {
            return PhysAttackDouble * (2 + Dexterity * 0.05);
        }

    }
}
