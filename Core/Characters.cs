using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        private double _strength;
        public double Min_Strength { get; set; }
        public double Max_Strength { get; set; }
        public double Strength
        {
            get { return _strength; }
            set
            {
                if (value >= Min_Strength && value <= Max_Strength)
                    _strength = value;
            }
        }

        private double _dexterity;
        public double Min_Dexterity { get; set; }
        public double Max_Dexterity { get; set; }
        public double Dexterity
        {
            get { return _dexterity; }

            set
            {
                if (value >= Min_Dexterity && value <= Max_Dexterity)
                    _dexterity = value;
            }
        }

        private double _intelligence;
        public double Min_Intelligence { get; set; }
        public double Max_Intelligence { get; set; }
        public double Intelligence
        {
            get { return _intelligence; }

            set
            {
                if (value >= Min_Intelligence && value <= Max_Intelligence)
                    _intelligence = value;
            }
        }

        private double _constitution;
        public double Min_Constitution { get; set; }
        public double Max_Constitution { get; set; }
        public double Constitution
        {
            get { return _constitution; }

            set
            {
                if (value >= Min_Constitution && value <= Max_Constitution)
                    _constitution = value;
            }
        }

        private double _health;
        public double Health
        {
            get 
            {
                _health = (2 * _constitution) + (0.5 * _strength);

                if (_health < 0.5 * _health)
                {
                    _strength =- _strength * 0.1;
                    _dexterity =- _dexterity * 0.1;
                    _intelligence =- _intelligence * 0.1;
                    _constitution =- _constitution * 0.1;
                }
                return _health; 
            }

            set { _health = value; }
        }

        private double _mana;
        public double Mana
        {
            get 
            {
                _mana = Intelligence * 3;

                if (_mana < 0.2 * _mana)
                {
                    _health =- _health * 0.2;
                }
                return _mana; 
            }
        }

        private Сharacteristic _characts => 
            new Сharacteristic(Strength, Dexterity, Intelligence, Constitution);
        public Сharacteristic Сharacts
        {
            get { return _characts; }
        }

        public int ExtraPoint = 5;
    }
}
