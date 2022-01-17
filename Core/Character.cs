using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Character
    {
        public string Name { get; set; }


        protected int _strength;
        public int Strength
        {
            get { return _strength; }
            set { _strength = value; }
        }

        protected int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }
            set { _dexterity = value; }
        }

        protected int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }
            set { _intelligence = value; }
        }

        protected int _constitution;
        public int Constitution
        {
            get { return _constitution; }
            set { _constitution = value; }
        }


        public int _maxStrength { get; protected set; }
        public int _maxDexterity { get; protected set; }
        public int _maxIntelligence { get; protected set; }
        public int _maxConstitution { get; protected set; }

        public int _minStrength { get; protected set; }
        public int _minDexterity { get; protected set; }
        public int _minIntelligence { get; protected set; }
        public int _minConstitution { get; protected set; }

        public int _health { get; protected set; }
        public int _mana { get; protected set; }

        public int _physicalAttack { get; protected set; }
        public int _magicalAttack { get; protected set; }

        public int _physicalDefense { get; protected set; }
        public int _magicalDefense { get; protected set; }

        public int _physicalCritChance { get; protected set; }
        public int _magicalCritChance { get; protected set; }

        public int _physicalCritDamage { get; protected set; }
        public int _magicalCritDamage { get; protected set; }

        public int _extrapoints { get; protected set; }

        protected void CountHealth()
        {
            this._health = 2 * _constitution + _strength / 2;
        }
        protected void CountMana()
        {
            this._mana = _intelligence * 3;
        }
        protected void CountPhysAttack()
        {
            this._physicalAttack = _strength * 3 + _dexterity / 2;
        }
        protected void CountMagAttack()
        {
            this._magicalAttack = _intelligence * 4;
        }
        protected void CountPhysDefence()
        {
            this._physicalDefense = _constitution / 2 + _dexterity * 3;
        }
        protected void CountMagDefence()
        {
            this._magicalDefense = _intelligence * 2;
        }
        protected void CountPhysCritChance()
        {
            this._physicalCritChance = 20 + Convert.ToInt32(_dexterity * 0.3);
        }
        protected void CountMagCritChance()
        {
            this._magicalCritChance = 20 + Convert.ToInt32(_intelligence * 0.1);
        }
        protected void CountPhysCritDamage()
        {
            this._physicalCritDamage = _physicalAttack * (2 + _dexterity / 20);
        }
        protected void CountMagCritDamage()
        {
            this._magicalCritDamage = _magicalAttack * (2 + Convert.ToInt32(_intelligence * 0.15));
        }


        public void Refresh()
        {
            CountHealth();
            CountMana();
            CountPhysAttack();
            CountMagAttack();
            CountPhysDefence();
            CountMagDefence();
            CountPhysCritChance();
            CountMagCritChance();
            CountPhysCritDamage();
            CountMagCritDamage();
        }


        public void IncreaseStrength()
        {
            if (_extrapoints > 0 && _strength != _maxStrength)
            {
                this._strength++;
                this._extrapoints--;
                Refresh();
            }
        }
        public void DecreaseStrength()
        {
            if (_strength != _minStrength)
            {
                this._strength--;
                this._extrapoints++;
                Refresh();
            }
        }

        public void IncreaseDexterity()
        {
            if (_extrapoints > 0 && _dexterity != _maxDexterity)
            {
                this._dexterity++;
                this._extrapoints--;
                Refresh();
            }
        }
        public void DecreaseDexterity()
        {
            if (_dexterity != _minDexterity)
            {
                this._dexterity--;
                this._extrapoints++;
                Refresh();
            }
        }


        public void IncreaseIntelligence()
        {
            if (_extrapoints > 0 && _intelligence != _maxIntelligence)
            {
                this._intelligence++;
                this._extrapoints--;
                Refresh();
            }
        }
        public void DecreaseIntelligence()
        {
            if (_intelligence != _minIntelligence)
            {
                this._intelligence--;
                this._extrapoints++;
                Refresh();
            }
        }


        public void IncreaseConstitution()
        {
            if (_extrapoints > 0 && _constitution != _maxConstitution)
            {
                this._constitution++;
                this._extrapoints--;
                Refresh();
            }
        }
        public void DecreaseConstitution()
        {
            if (_constitution != _minConstitution)
            {
                this._constitution--;
                this._extrapoints++;
                Refresh();
            }
        }
    }
}
