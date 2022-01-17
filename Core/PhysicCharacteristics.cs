using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PhysicCharacteristics : Characteristics
    {
        public PhysicCharacteristics(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = 3 * Strength + 0.5 * Dexterity;
            Defense = 0.5 * Constitution + 3 * Dexterity;
            CriticalChance = 20 + 0.3 * Constitution;
            CriticalDamage = Attack * (2 + 0.05 * Constitution);
        }
    }
}