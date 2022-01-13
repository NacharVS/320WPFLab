using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Main
{
    class Сharacteristic
    {
        public double Health(int Constitution, double Strength)
        {
            return 2 * Constitution + 0.5 * Strength;
        }

        public double Mana(int Intelligence)
        {
            return Intelligence * 3;
        }
    }
}
