using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        public enum HeroClass
        {
            Archer,
            Mage,
            Warrior
        }

        private double strength;
        public double Strength
        {
            get { return strength; }

            set { strength = value; }
        }

        private double dexterity;
        public double Dexterity
        {
            get { return dexterity; }

            set { dexterity = value; }
        }

        private double intelligence;
        public double Intelligence
        {
            get { return intelligence; }

            set { intelligence = value; }
        }

        private double constitution;
        public double Constitution
        {
            get { return constitution; }

            set { constitution = value; }
        }

        private double health;
        public double Health
        {
            get 
            {
                health = 2 * constitution + 0.5 * strength;

                if (health < 0.5 * health)
                {
                    strength =- strength * 0.1;
                    dexterity =- dexterity * 0.1;
                    intelligence =- intelligence * 0.1;
                    constitution =- constitution * 0.1;
                }
                return health; 
            }

            set { health = value; }
        }

        private double mana;
        public double Mana
        {
            get 
            {
                mana = Intelligence * 3;

                if (mana < 0.2 * mana)
                {
                    health =- health * 0.2;
                }
                return mana; 
            }
        }

        private Сharacteristic characts => 
            new Сharacteristic(Strength, Dexterity, Intelligence, Constitution);
        public Сharacteristic Сharacts
        {
            get { return characts; }
        }

        protected int ExtraPoint = 500;
    }
}
