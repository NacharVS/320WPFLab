using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Models
{
    internal abstract class Character
    {
        private int _extraPoint;
        public int ExtraPoint
        {
            get => _extraPoint;
            set
            {
                _extraPoint = value;
            }
        }

        private string _name;
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        private int _strength;
        public virtual int Strength
        {
            get => _strength;
            set
            {
                _strength = value;
            }
        }

        private int _dexterity;
        public virtual int Dexterity
        {
            get => _dexterity;
            set
            {
                _dexterity = value;
            }
        }

        private int _intelligence;
        public virtual int Intelligence
        {
            get => _intelligence;
            set
            {
                _intelligence = value;
            }
        }

        private int _constitution;
        public virtual int Constitution
        {
            get => _constitution;
            set
            {
                _constitution = value;
            }
        }

        private double _health;
        public virtual double Health
        {
            get => _health;
            set
            {
                _health = value;
            }
        }

        private double _mana;
        public virtual double Mana
        {
            get => _mana;
            set
            {
                _mana = value;
            }
        }

        private double _pAttack;
        public double PAttack
        {
            get => _pAttack;
            set
            {
                _pAttack = value;
            }
        }

        private double _pResist;
        public double PResist
        {
            get => _pResist;
            set
            {
                _pResist = value;
            }
        }

        private double _mAttack;
        public double MAttack
        {
            get => _mAttack;
            set
            {
                _mAttack = value;
            }
        }

        private double _mResist;
        public double MResist
        {
            get => _mResist;
            set
            {
                _mAttack = value;
            }
        }

        private double _physCritChance;
        public double PhysCritChance
        {
            get => _physCritChance;
            set
            {
                _mAttack = value;
            }
        }

        private double _magCritChance;
        public double MagCritChance
        {
            get => _magCritChance;
            set
            {
                _magCritChance = value;
            }
        }

        public double PhysCritDamage { get => _physCritDamage; set => _physCritDamage = value; }
        public double MagCritDamage { get => _magCritDamage; set => _magCritDamage = value; }

        private double _physCritDamage;

        private double _magCritDamage;
    }
}
