using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MagicСharacteristic : Сharacteristic
    {
        public MagicСharacteristic(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = 4 * Intelligence;
            Defense = 2 * Intelligence;
            CriticalChance = 20 + 0.1 * Intelligence;
            CriticalDamage = Attack * (2 + 0.15 * Intelligence);
        }
    }
}
