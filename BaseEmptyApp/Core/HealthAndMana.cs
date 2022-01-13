using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class HealthAndMana
    {
        public double Health(int Constitution, int Strength)
        {
            return 2*Constitution+ 0.5 *Strength;
        }

        public double Mana(int Intelligence)
        {
            return Intelligence * 3;
        }
    }
}
