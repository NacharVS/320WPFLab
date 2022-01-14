using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class Archer : Player
    {
        double str = 20;
        double dex = 30;
        double inT = 15;
        double con = 20;

        double max_str = 55;
        double max_dex = 250;
        double max_inT = 70;
        double max_con = 70;
        public Archer(double str, double dex, double inT, double con) : base(str, dex, inT, con)
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
