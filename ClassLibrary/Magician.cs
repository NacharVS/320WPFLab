using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Magician : Character
    {
        public Magician() : base()
        {
            Strength = minSrtength = 15;
            Dexterity = minDexterity = 20;
            Intelligence = minIntelligence = 30;
            Constitution = minConstitution = 15;
            this.maxSrtength = 45;
            this.maxDexterity = 70;
            this.maxIntelligence = 250;
            this.maxConstitution = 65;
        }
        public override string ToString()
        {
            return "Magician";
        }
    }
}
