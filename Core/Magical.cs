using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public abstract class Magical : PhysicalMagical
    {
        public Magical(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            GetCharacteristics(Strength, Dexterity, Intelligence, Constitution);
        }

        public override void GetCharacteristics(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = 4 * Intelligence;
            Defense = 2 * Intelligence;
            CriticalChanse = 20 + 0.1 * Intelligence;
            CriticalDamage = Attack * (2 + 0.15 * Intelligence);
        }
    }
}
