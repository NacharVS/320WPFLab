using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        private int _strength;
        protected int Strength
        {
            get { return _strength; }

            set { _strength = value; }
        }

        private int _dexterity;
        protected int Dexterity
        {
            get { return _dexterity; }
            
            set { _dexterity = value; }
        }

        private int _intelligence;
        protected int Intelligence
        {
            get { return _intelligence; }
            
            set { _intelligence = value; }
        }

        private int _constitution;
        protected int Constitution
        {
            get { return _constitution; }

            set { _constitution = value; }
        }

        private double _health => 2 * _constitution + 0.5 * _strength;
        protected double Health { get { return _health; } }

        private double _mana => Intelligence * 3;
        protected double Mana { get { return _mana; } }

        private MagicСharacteristic _magic => new MagicСharacteristic(Strength, Dexterity, Intelligence, Constitution);
        protected MagicСharacteristic Magic
        {
            get { return _magic; }
        }
        private PhysicСharacteristic _physic => new PhysicСharacteristic(Strength, Dexterity, Intelligence, Constitution);
        protected PhysicСharacteristic Physic
        {
            get { return _physic; }
        }

        protected int ExtraPoint = 500;
    }
}
