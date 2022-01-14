using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCore
{
    public abstract class Unit
    {
        private int _strength;
        public int Strength
        {
            get { return _strength; }

            set { _strength = value; }
        }

        private int _dexterity;
        public int Dexterity
        {
            get { return _dexterity; }

            set { _dexterity = value; }
        }

        private int _intelligence;
        public int Intelligence
        {
            get { return _intelligence; }

            set { _intelligence = value; }
        }

        private int _constitution;
        public int Constitution
        {
            get { return _constitution; }

            set { _constitution = value; }
        }

        private double _health => 2 * _constitution + 0.5 * _strength;
        public double Health
        {
            get { return _health; }
        }

        private double _mana => Intelligence * 3;
        public double Mana
        {
            get { return _mana; }
        }

        private MagicСharacteristic _magic => new MagicСharacteristic(Strength, Dexterity, Intelligence, Constitution);
        public MagicСharacteristic Magic
        {
            get { return _magic; }
        }
        private PhysicСharacteristic _physic => new PhysicСharacteristic(Strength, Dexterity, Intelligence, Constitution);
        public PhysicСharacteristic Physic
        {
            get { return _physic; }
        }

        protected int ExtraPoint = 500;


    }
}
