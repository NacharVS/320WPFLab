using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class MagicСharacteristic : Сharacteristic
    {
        public MagicСharacteristic(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Update(Strength, Dexterity, Intelligence, Constitution);
        }

        public override void Update(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = 4 * Intelligence;
            Defense = 2 * Intelligence;
            CriticalChance = 20 + 0.1 * Intelligence;
            CriticalDamage = Attack * (2 + 0.15 * Intelligence);
        }
    }
}
