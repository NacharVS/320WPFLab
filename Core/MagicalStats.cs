using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class MagicalStats : PhysicalMagicalStats
    {
        public MagicalStats(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            GetCharacteristics(Strength, Dexterity, Intelligence, Constitution);
        }

        public override void GetCharacteristics(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = Intelligence * 4;
            Defense = Intelligence * 2;
            CriticalChanse = 20 + Intelligence * 0.1;
            CriticalDamage = Attack * (2 + Intelligence * 0.15);
        }
    }
}
