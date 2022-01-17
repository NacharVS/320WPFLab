using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        public Character()
        {
            Strength = MinStrength; //Сила
            Dexterity = MinDexterity; //Ловкость
            Intelligence = MinIntelligence; //Интеллект
            Constitution = MinConstitution; //телосложение
        }
        private double _strength;
        public virtual double MinStrength { get; }
        public virtual double MaxStrength { get; }
        public double Strength
        {
            get
            {
                return _strength;
            }

            set
            {
                if (value >= MinStrength & value <= MaxStrength)
                    _strength = value;
                else
                    throw new Exception("Cannot set this value");
            }
        }
        private double _dexterity;
        public virtual double MinDexterity { get; }
        public virtual double MaxDexterity { get; }
        public double Dexterity
        {
            get { return _dexterity; }

            set
            {
                if (value >= MinDexterity & value <= MaxDexterity)
                    _dexterity = value;
                else
                    throw new Exception("Cannot set this value");
            }
        }

        private double _intelligence;
        public virtual double MinIntelligence { get; }
        public virtual double MaxIntelligence { get; }
        public double Intelligence
        {
            get { return _intelligence; }

            set
            {
                if (value >= MinIntelligence & value <= MaxIntelligence)
                    _intelligence = value;
                else
                    throw new Exception("Cannot set this value");
            }
        }

        private double _constitution;
        public virtual double MinConstitution { get; }
        public virtual double MaxConstitution { get; }
        public double Constitution
        {
            get { return _constitution; }

            set
            {
                if (value >= MinConstitution & value <= MaxConstitution)
                    _constitution = value;
                else
                    throw new Exception("Cannot set this value");
            }
        }

        private double _health => 2 * Constitution + 0.5 * Strength;
        public double Health
        {
            get { return _health; }
        }

        private double _mana => Intelligence * 3;
        public double Mana
        {
            get { return _mana; }
        }

        private MagicCharacteristics _magic => new MagicCharacteristics(Strength, Dexterity, Intelligence, Constitution);
        public MagicCharacteristics Magic
        {
            get { return _magic; }
        }
        private PhysicCharacteristics _physic => new PhysicCharacteristics(Strength, Dexterity, Intelligence, Constitution);
        public PhysicCharacteristics Physic
        {
            get { return _physic; }
        }

        public int Points { get; set; } = 100;
    }
}
