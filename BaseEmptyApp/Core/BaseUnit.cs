namespace BaseEmptyApp.Core
{
    public class BaseUnit
    {
        private int _strength;
        public virtual double MinStrength { get; }
        public virtual double MaxStrength { get; }
        public int Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                    _strength = value;
            }
        }

        public virtual double MinDexterity { get; }
        public virtual double MaxDexterity { get; }

        private int _dexterity;
        public int Dexterity
        {
            get
            {
                return _dexterity;
            }

            set
            {
                _dexterity = value;
            }
        }

        public virtual double MinIntelligence { get; }
        public virtual double MaxIntelligence { get; }

        private int _intelligence;
        public int Intelligence
        {
            get
            {
                return _intelligence;
            }

            set
            {
                _intelligence = value;
            }
        }


        public virtual double MinConstitution { get; }
        public virtual double MaxConstitution { get; }

        private int _constitution;
        public int Constitution
        {
            get
            {
                return _constitution;
            }

            set
            {
                _constitution = value;
            }
        }

        private double _health => 2 * _constitution + 0.5 * _strength;
        public double Health
        {
            get
            {
                return _health;
            }
        }

        private double _mana => Intelligence * 3;
        public double Mana
        {
            get
            {
                return _mana;
            }
        }

        private Magic _magic => new Magic(Strength, Dexterity, Intelligence, Constitution);
        public Magic Magic
        {
            get
            {
                return _magic;
            }
        }
        private Physics _physic => new Physics(Strength, Dexterity, Intelligence, Constitution);
        public Physics Physic
        {
            get
            {
                return _physic;
            }
        }

        public string Image { get; set; }
        
        private int _extraPoints = 5;
        public int ExtraPoint
        {
            get
            {
                return _extraPoints;
            }
            set
            {
                _extraPoints = _extraPoints - value;
            }
        }

    }


}
