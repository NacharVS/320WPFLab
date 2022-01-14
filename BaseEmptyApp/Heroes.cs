using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    class Heroes
    {
         class Warrior : BaseUnit
    {
        public Warrior() : base()
        {
            mistr = 30;
            mastr = 250;
            mid = 15;
            mad = 80;
            miin = 10;
            main = 50;
            mico = 25;
            maco = 100;
        }
    }

    class Archer : BaseUnit
        {
        public Archer() : base()
        {
            mistr = 20;
            mastr = 55;
            mid = 30;
            mad = 250;
            miin = 15;
            main = 70;
            mico = 20;
            maco = 70;
        }
    }

    class Mage : BaseUnit
        {
        public Mage() : base()
        {
            mistr = 15;
            mastr = 45;
            mid = 20;
            mad = 70;
            miin = 30;
            main = 250;
            mico = 15;
            maco = 65;
        }
    }
    }
}
