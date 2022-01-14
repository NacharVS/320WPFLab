using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Warrior : Character
    {
        private int ClassMinStrength = 30;
        private int ClassMaxStrength = 250;
        private int ClassMinDext = 15;
        private int ClassMaxDext = 80;
        private int ClassMinInt = 10;
        private int ClassMaxInt = 50;
        private int ClassMinConst = 25;
        private int ClassMaxConst = 25;

        public Warrior(string name, int s, int d, int i, int c) : base(name, s, d, i, c)
        {   }

        public void SetStrength(int newS)
        {
            if (newS >= this.ClassMinStrength && newS <= this.ClassMaxStrength)
            {
                this.Strength = newS;
            }
        }
        public void SetDext(int newD)
        {
            if (newD >= this.ClassMinDext && newD <= this.ClassMaxDext)
            {
                this.Dexterity = newD;
            }
        }
        public void SetInt(int newI)
        {
            if (newI >= this.ClassMinInt && newI <= this.ClassMaxInt)
            {
                this.Intelligence = newI;        
            }
        }
        public void SetConst(int newC)
        {
            if (newC >= this.ClassMinConst && newC <= this.ClassMaxConst)
            {
                this.Constitution = newC;        
            }
        }

    }
}
