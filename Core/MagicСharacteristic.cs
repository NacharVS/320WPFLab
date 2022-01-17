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
            Attack = Math.Round(4 * Intelligence, 5);
            Defense = Math.Round(2 * Intelligence, 5);
            CriticalChance = Math.Round(20 + 0.1 * Intelligence, 5);
            CriticalDamage = Math.Round(Attack * (2 + 0.15 * Intelligence), 5);
        }
    }
}
