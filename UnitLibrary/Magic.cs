using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Magic : Feature
    {
        public Magic(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = Math.Round(4 * Intelligence, 2);
            Defense = Math.Round(2 * Intelligence, 2);
            CriticalChance = Math.Round(20 + 0.1 * Intelligence, 2);
            CriticalDamage = Math.Round(Attack * (2 + 0.15 * Intelligence), 2);
        }
    }
}
