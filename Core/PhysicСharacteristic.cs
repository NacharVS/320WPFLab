using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PhysicСharacteristic : Сharacteristic
    {
        public PhysicСharacteristic(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = Math.Round(3 * Strength + 0.5 * Dexterity, 5);
            Defense = Math.Round(0.5 * Constitution + 3 * Dexterity, 5);
            CriticalChance = Math.Round(20 + 0.3 * Constitution, 5);
            CriticalDamage = Math.Round(Attack * (2 + 0.05 * Constitution), 5);
        }
    }
}
