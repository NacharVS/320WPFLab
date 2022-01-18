using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Physics : Feature
    {
        public Physics(double Strength, double Dexterity, double Intelligence, double Constitution)
        {
            Attack = Math.Round(3 * Strength + 0.5 * Dexterity, 2);
            Defense = Math.Round(0.5 * Constitution + 3 * Dexterity, 2);
            CriticalChance = Math.Round(20 + 0.3 * Constitution, 2);
            CriticalDamage = Math.Round(Attack * (2 + 0.05 * Constitution), 2);
        }
    }
}
