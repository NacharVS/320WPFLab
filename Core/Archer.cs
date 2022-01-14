using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Character
    {
        private int ClassMinStrength = 20;
        private int ClassMaxStrength = 55;
        private int ClassMinDext = 30;
        private int ClassMaxDext = 250;
        private int ClassMinInt = 15;
        private int ClassMaxInt = 70;
        private int ClassMinConst = 20;
        private int ClassMaxConst = 70;

        public Archer(string name, int s, int d, int i, int c) : base(name, s, d, i, c)
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
