using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Main
{
    class PhysicalData
    {
        public double PhysicalAttack(int Strength, double Dexterity)
        {
            return Strength * 3 + 0.5 * Dexterity;
        }
        public double PhysicalDefense(double Constitution, int Dexterity)
        {
            return Constitution * 0.5 + Dexterity * 3;
        }

        public double MagicAttack(int Intelligence)
        {
            return Intelligence * 4;
        }

        public double MagicDefense(int Intelligence)
        {
            return Intelligence * 2;
        }

        public double PhysicalCriticalChanse(double Dexterity)
        {
            return 20 + Dexterity * 0.3;
        }

        public double MagicCriticalChanse(double Intelligence)
        {
            return 20 + Intelligence * 0.1;
        }

        public double PhysicalCriticalDamage(double PhysAttack, double Dexterity)
        {
            return PhysAttack * (2 + Dexterity * 0.05);
        }

        public double MagicCriticalDamage(double MagAttack, double Intelligence)
        {
            return MagAttack * (2 + Intelligence * 0.15);
        }
    }
}