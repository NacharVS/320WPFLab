using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class PhysicStatistics : Statistics
    {
        public PhysicStatistics(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            GetCharacteristics(Strength, Dexterity, Intelligence, Constitution);
        }
        public override void GetCharacteristics(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = Strength * 3 + 0.5 * Dexterity;
            Defense = Constitution * 0.5 + Dexterity * 3;
            CriticalChanse = 20 + Dexterity * 0.3;
            CriticalDamage = Attack * (2 + Dexterity * 0.05);
        }
    }
}