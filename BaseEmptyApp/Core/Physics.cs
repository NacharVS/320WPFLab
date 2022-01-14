using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class Physics : Feature
    {
        public Physics(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = 3 * Strength + 0.5 * Dexterity;
            Defense = 0.5 * Constitution + 3 * Dexterity;
            CriticalChance = 20 + 0.3 * Constitution;
            CriticalDamage = Attack * (2 + 0.05 * Constitution);
        }
    }
}
