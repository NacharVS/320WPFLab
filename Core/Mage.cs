using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Mage : Character
    {
        private int _classMinStrength = 15;
        private int _classMaxStrength = 45;
        private int _classMinDext = 20;
        private int _classMaxDext = 70;
        private int _classMinInt = 30;
        private int _classMaxInt = 250;
        private int _classMinConst = 15;
        private int _classMaxConst = 65;

        public Mage(int s, int d, int i, int c) : base(s, d, i, c)
        { }

        public bool AddStrength()
        {
            if (this.Strength + 1 <= this._classMaxStrength)
            {
                this.Strength++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddDext()
        {
            if (this.Dexterity + 1 <= this._classMaxDext)
            {
                this.Dexterity++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddInt()
        {
            if (this.Intelligence + 1 <= this._classMaxInt)
            {
                this.Intelligence++;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool AddConst()
        {
            if (this.Constitution + 1 <= this._classMaxConst)
            {
                this.Constitution++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveStrength()
        {
            if (this.Strength - 1 >= this._classMinStrength)
            {
                this.Strength--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveDext()
        {
            if (this.Dexterity - 1 >= this._classMinDext)
            {
                this.Dexterity--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveInt()
        {
            if (this.Intelligence - 1 >= this._classMinInt)
            {
                this.Intelligence--;
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveConst()
        {
            if (this.Constitution - 1 >= this._classMinConst)
            {
                this.Constitution--;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
