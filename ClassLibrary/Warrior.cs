using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Warrior : Character
    {
        public Warrior() : base()
        {
            Strength = minSrtength = 30;
            Dexterity = minDexterity = 15;
            Intelligence = minIntelligence = 10;
            Constitution = minConstitution = 25;
            maxSrtength = 250;
            maxDexterity = 80;
            maxIntelligence = 50;
            maxConstitution = 100;
        }
        public override string ToString()
        {
            return "Warrior";
        }
    }
}
