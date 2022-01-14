using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class Warrior : BaseUnit
    {
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
        }
    }

    public class Archer : BaseUnit
    {
        public Archer()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
        }
    }

    public class Mage : BaseUnit
    {
        public Mage()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 30;
            Constitution = 15;
        }
    }
}
