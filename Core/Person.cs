using System;

namespace Core
{
    public class Person
    {
        //private int _levelingPoints;
        //public int LevelingPoints { get { return _levelingPoints; } set { _levelingPoints = value; } }
        public int LevelingPoints = 100;

        private int _strength;
        public int Strenght { get { return _strength; } set { _strength = value; } }
        
        private int _dexterity;
        public int Dexterity { get { return _strength; } set { _strength = value; } }

        private int _intelligence;
        public int Intelligence { get { return _strength; } set { _strength = value; } }

        private int _constitution;
        public int Constitution { get { return _strength; } set { _strength = value; } }


        private double _health => (2 * _constitution) + (0.5 * _strength);
        public double Health { get { return _health; } }

        private double _pAttack => (_strength * 3) + (0.5 * _dexterity);
        public double PAttack { get { return _pAttack; } }

        private double _pDefense => (_constitution * 0.5) + (_dexterity * 3);
        public double PDefense { get { return _pDefense; } }

        private double _mAttack => _intelligence * 4;
        public double MAttack { get { return _mAttack; } }

        private double _mDefense => _intelligence * 2;
        public double MDefense { get { return _mDefense; } }

        private double _pCriticalChanse => 20 + _dexterity * 0.3;
        public double PCriticalChanse { get { return _pCriticalChanse; } }

        private double _mCriticalChanse => 20 + _intelligence * 0.1;
        public double MCriticalChanse { get { return _mCriticalChanse; } }

        private double _pCriticalDamage => _pAttack * (2 + _dexterity * 0.05);
        public double PCriticalDamage { get { return _pCriticalDamage; } }

        private double _mCriticalDamage => _mAttack * (2 + _intelligence * 0.15);
        public double MCriticalDamage { get { return _mCriticalDamage; } }
    }
}
    