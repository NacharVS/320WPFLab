using System;

namespace CharacterLibrary
{
    public abstract class Character
    {
        private int _strength;
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

        protected int ExtraPoint = 500;
    }
}
