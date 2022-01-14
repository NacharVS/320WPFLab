using System;

namespace CharacterLibrary
{
    public abstract class Character
    {
        public virtual double minStrength { get; }
        public virtual double maxStrength { get; }

        public virtual double minDexterity { get; }
        public virtual double maxDexterity { get; }

        public virtual double minIntelligence { get; }
        public virtual double maxIntelligence { get; }

        public virtual double minConstitution { get; }
        public virtual double maxConstitution { get; }

        private double _strength;
        public double Strength
        {
            get 
            { 
                return _strength; 
            }

            set 
            { 
                if (value <= maxStrength & value >= minStrength)
                    _strength = value; 
            }
        }

        private double _dexterity;
        public double Dexterity
        {
            get 
            { 
                return _dexterity; 
            }

            set 
            { 
                if (value <= maxDexterity & value >= minDexterity)
                    _dexterity = value; 
            }
        }

        private double _intelligence;
        public double Intelligence
        {
            get 
            { 
                return _intelligence; 
            }

            set 
            {
                if (value <= maxIntelligence & value >= minIntelligence)
                    _intelligence = value;

            }
        }

        private int _constitution;
        public int Constitution
        {
            get 
            {
                return _constitution; 
            }

            set 
            {
                if (value <= maxConstitution & value >= minConstitution)
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

        protected int ExtraPoint = 500;
    }
}
