using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Magician : Character
    {
        public Magician(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            this.minSrtength = 15;
            this.minDexterity = 20;
            this.Intelligence = 30;
            this.minConstitution = 15;
            this.maxSrtength = 45;
            this.maxDexterity = 70;
            this.maxIntelligence = 250;
            this.maxConstitution = 65;
        }
    }
}
