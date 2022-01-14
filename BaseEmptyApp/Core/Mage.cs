using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class Mage : Player
    {
        double str = 15;
        double dex = 20;
        double inT = 30;
        double con = 15;

        double max_str = 45;
        double max_dex = 70;
        double max_inT = 250;
        double max_con = 65;
        public Mage(double str, double dex, double inT, double con) : base(str, dex, inT, con)
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
