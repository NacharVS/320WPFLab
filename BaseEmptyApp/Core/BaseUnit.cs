using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    abstract class BaseUnit
    {
        protected int mistr { get; set; }
        protected int mastr { get; set; }
        protected int mid { get; set; }
        protected int mad { get; set; }
        protected int miin { get; set; }
        protected int main { get; set; }
        protected int mico { get; set; }
        protected int maco { get; set; }

        int extraPoints = 5;
        protected int Constitution;
        protected int Strength;
        protected int Dexterity;
        protected int Intelligence;

        double Health;
        double Mana;

        public BaseUnit()
        {
            Strength = mistr;
            Dexterity = mid;
            Intelligence = miin;
            Constitution = mico;
            Health = 2 * Constitution + 0.5 * Strength;
            Mana = Intelligence * 3;
        }
    }

}
