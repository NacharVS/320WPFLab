using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Mage : Character
    {
        public int minS = 15;
        public int minD = 20;
        public int minI = 30;
        public int minC = 15;
        public int maxS = 45;
        public int maxD = 70;
        public int maxI = 250;
        public int maxC = 65;
        public Mage(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            strength = this.strength;
            dexterity = this.dexterity;
            intelligence = this.intelligence;
            constitution = this.constitution;
        }
    }
}
