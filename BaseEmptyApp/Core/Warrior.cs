using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class Warrior : Player
    {
        double str = 30;
        double dex = 15;
        double inT = 10;
        double con = 25;

        double max_str = 250;
        double max_dex = 80;
        double max_inT = 50;
        double max_con = 100;
        public Warrior(double str, double dex, double inT, double con) : base(str, dex, inT, con)
        {
        }

        public override double Strength_Plus()
        {
            if (Strength < max_str)
            {
                Strength = Strength + 1;
                return Strength;
            }
            else
            {
                return Strength;
            }
        }
    }
}
