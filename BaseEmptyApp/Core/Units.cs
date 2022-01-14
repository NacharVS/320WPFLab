using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class Warrior : PhysicalUnit
    {
        public Warrior() : base()
        {
            minStrenght = 30;
            maxStrenght = 250;
            minDexterity = 15;
            maxDexterity = 80;
            minIntelligence = 10;
            maxIntelligence = 50;
            minConstitution = 25;
            maxConstitution = 100;
        }
    }

    class Archer : PhysicalUnit
    {
        public Archer() : base()
        {
            minStrenght = 20;
            maxStrenght = 55;
            minDexterity = 30;
            maxDexterity = 250;
            minIntelligence = 15;
            maxIntelligence = 70;
            minConstitution = 20;
            maxConstitution = 70;
        }
    }

    class Mage : MagicUnit
    {
        public Mage() : base()
        {
            minStrenght = 15;
            maxStrenght = 45;
            minDexterity = 20;
            maxDexterity = 70;
            minIntelligence = 30;
            maxIntelligence = 250;
            minConstitution = 15;
            maxConstitution = 65;
        }
    }
}
