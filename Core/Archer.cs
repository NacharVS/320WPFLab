using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Archer : Character
    {
        public Archer(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            this.minSrtength = 20;
            this.minDexterity = 30;
            this.Intelligence = 15;
            this.minConstitution = 20;
            this.maxSrtength = 55;
            this.maxDexterity = 250;
            this.maxIntelligence = 70;
            this.maxConstitution = 70;
        }
    }
}
