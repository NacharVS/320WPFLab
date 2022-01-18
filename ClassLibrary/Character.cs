using System;

namespace Core
{
    abstract public class Character
    {
        private int _strength;
        private int _dexterity;
        private int _intelligence;
        private int _constitution;

        private double _maxHp;
        private double _maxMp;

        public double MaxHp
        {
            get => _maxHp;
            set => _maxHp = GetHp();
        }
        public double MaxMp
        {
            get => _maxMp;
            set => _maxMp = GetMana();
        }

        public int Strength
        {
            get => _strength;
            set => this._strength = CheckStrength(value);
        }
        public int Dexterity
        {
            get => _dexterity;
            set => this._dexterity = CheckDex(value);
        }
        public int Intelligence
        {
            get => _intelligence;
            set => this._intelligence = CheckIntell(value);
        }
        public int Constitution
        {
            get => _constitution;
            set => this._constitution = CheckConst(value);
        }
        public double Health { get; protected set; }
        public double Mana { get; protected set; }


        public int minSrtength { get; protected set; }
        public int minDexterity { get; protected set; }
        public int minIntelligence { get; protected set; }
        public int minConstitution { get; protected set; }

        public int maxSrtength { get; protected set; }
        public int maxDexterity { get; protected set; }
        public int maxIntelligence { get; protected set; }
        public int maxConstitution { get; protected set; }

        public Character()
        {
            MaxHp = 0;
            MaxMp = 0;

            Health = MaxHp;
            Mana = MaxMp;
        }

        public double GetHp()
        {
            return (2 * this.Constitution + 0.5 * this.Strength);
        }

        public double GetMana()
        {
            return (this.Intelligence * 3);
        }

        public double PhysicalAttack()
        {
            return (this.Strength * 3) + (0.5 * this.Dexterity);
        }

        public double PhysicalDef()
        {
            return (this.Constitution * 0.5) + (3 * this.Dexterity);
        }

        public double MagicAttack()
        {
            return this.Intelligence * 4;
        }

        public double MagicDef()
        {
            return this.Intelligence * 2;
        }

        public double PCritChance()
        {
            return 20 + this.Dexterity * 0.3;
        }

        public double MCritChance()
        {
            return 20 + this.Intelligence * 0.1;
        }

        public double PCritDamage()
        {
            return PhysicalAttack() * (2 + this.Dexterity * 0.05);
        }

        public double MCritDamage()
        {
            return MagicAttack() * (2 + this.Intelligence * 0.15);
        }

        private int CheckStrength(int str)
        {
            if (str >= this.minSrtength && str <= this.maxSrtength)
                return str;
            else if (this.Strength == 0)
                return minSrtength;
            return this.Strength;
        }
        private int CheckDex(int dex)
        {
            if (dex >= this.minDexterity && dex <= this.maxDexterity)
                return dex;
            else if (this.Dexterity == 0)
                return minDexterity;
            return this.Dexterity;
        }
        private int CheckIntell(int intell)
        {
            if (intell >= this.minIntelligence && intell <= this.maxIntelligence)
                return intell;
            else if (this.Intelligence == 0)
                return minIntelligence;
            return this.Intelligence;
        }
        private int CheckConst(int con)
        {
            if (con >= this.minConstitution && con <= this.maxConstitution)
                return con;
            else if (this.Constitution == 0)
                return minConstitution;
            return this.Constitution;
        }

        public void Cast(double mana)
        {
            this.Mana -= mana;
            CheckMp();
        }

        private void CheckMp()
        {
            if (this.Mana < this.MaxMp * 0.2)
                _maxHp *= 0.8;
        }

        public void GetDamage(double damage)
        {
            this.Health -= damage;
            CheckHp();
        }
        private void CheckHp()
        {
            if (this.Health < this.MaxHp * 0.5)
                this.Strength -= Convert.ToInt32(Strength * 0.1);
            this.Dexterity -= Convert.ToInt32(Strength * 0.1);
            this.Intelligence -= Convert.ToInt32(Strength * 0.1);
            this.Constitution -= Convert.ToInt32(Strength * 0.1);
        }
    }
}
