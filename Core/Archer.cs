using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Character
    {
        public Archer()
        {
            Strength = this.minSrtength = 20;
            Dexterity = this.minDexterity = 30;
            Intelligence = this.minIntelligence = 15;
            Constitution = this.minConstitution = 20;
            this.maxSrtength = 55;
            this.maxDexterity = 250;
            this.maxIntelligence = 70;
            this.maxConstitution = 70;
        }
        public override string ToString()
        {
            return "Archer";
        }
    }
}
