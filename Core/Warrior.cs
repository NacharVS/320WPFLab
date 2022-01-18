namespace Core
{
    public class Warrior : Character
    {
        private int _classMinStrength = 30;
        private int _classMaxStrength = 250;
        private int _classMinDext = 15;
        private int _classMaxDext = 80;
        private int _classMinInt = 10;
        private int _classMaxInt = 50;
        private int _classMinConst = 25;
        private int _classMaxConst = 100;

        public Warrior(int s, int d, int i, int c) : base(s, d, i, c)
        {   }

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
            if (this.Strength - 1 > this._classMinStrength)
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
            if (this.Dexterity - 1 > this._classMinDext)
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
            if (this.Intelligence - 1 > this._classMinInt)
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
            if (this.Constitution - 1 > this._classMinConst)
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
