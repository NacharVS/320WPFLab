using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Units
{
    public class MagicСharacteristic: Сharacteristic
    {
        public MagicСharacteristic(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = 4 * Intelligence;
            Defense = 2 * Intelligence;
            CriticalChance = 20 + 0.1 * Intelligence;
            CriticalDamage = Attack * (2 + 0.15 * Intelligence);
        }
    }
}
