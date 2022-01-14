using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Warrior : Character
    {
        public int minS = 30;
        public int minD = 15;
        public int minI = 10;
        public int minC = 25;
        public int maxS = 250;
        public int maxD = 80;
        public int maxI = 50;
        public int maxC = 100;
        public Warrior(int strength, int dexterity, int intelligence, int constitution) : base(strength, dexterity, intelligence, constitution)
        {
            strength = this.strength;
            dexterity = this.dexterity;
            intelligence = this.intelligence;
            constitution = this.constitution;
            
        }
        
    }
}
