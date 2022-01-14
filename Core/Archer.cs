using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Archer : Character
    {
        public int minS = 20;
        public int minD = 30;
        public int minI = 15;
        public int minC = 20;
        public int maxS = 55;
        public int maxD = 250;
        public int maxI = 70;
        public int maxC = 70;
        public Archer(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            strength = this.strength;
            dexterity = this.dexterity;
            intelligence = this.intelligence;
            constitution = this.constitution;
        }
    }
}
