using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Warrior : Character
    {
        public Warrior(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            this.minSrtength = 30;
            this.minDexterity = 15;
            this.Intelligence = 10;
            this.minConstitution = 25;
            this.maxSrtength = 250;
            this.maxDexterity = 80;
            this.maxIntelligence = 50;
            this.maxConstitution = 100;
        }
    }
}
