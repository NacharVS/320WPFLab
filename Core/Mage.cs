using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Mage : Character
    {
        private int ClassMinStrength = 15;
        private int ClassMaxStrength = 45;
        private int ClassMinDext = 20;
        private int ClassMaxDext = 70;
        private int ClassMinInt = 30;
        private int ClassMaxInt = 250;
        private int ClassMinConst = 15;
        private int ClassMaxConst = 65;

        public Mage(string name, int s, int d, int i, int c) : base(name, s, d, i, c)
        { }

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
