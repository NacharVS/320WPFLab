using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Magic : Feature
    {
        public Magic(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = 4 * Intelligence;
            Defense = 2 * Intelligence;
            CriticalChance = 20 + 0.1 * Intelligence;
            CriticalDamage = Attack * (2 + 0.15 * Intelligence);
        }
    }
}
