using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        private int strength;
        public int Strength
        {
            get { return strength; }

            set { strength = value; }
        }

        private int dexterity;
        public int Dexterity
        {
            get { return dexterity; }

            set { dexterity = value; }
        }

        private int intelligence;
        public int Intelligence
        {
            get { return intelligence; }

            set { intelligence = value; }
        }

        private int constitution;
        public int Constitution
        {
            get { return constitution; }

            set { constitution = value; }
        }

        private double health => 2 * constitution + 0.5 * strength;
        public double Health
        {
            get 
            {
                if (health < 0.5 * health)
                {
                    strength = (int)(- strength * 0.1);
                    dexterity = (int)(- dexterity * 0.1);
                    intelligence = (int)(- intelligence * 0.1);
                    constitution = (int)(- constitution * 0.1);
                }
                return health; 
            }
        }

        private double mana => Intelligence * 3;
        public double Mana
        {
            get 
            {
                if (mana < 0.2 * mana)
                {
                    health =- health * 0.2;
                }
                return mana; 
            }
        }

        /// <summary>
        /// ///////////////////////////////////////
        /// </summary>
        private Сharacteristic characts => 
            new Сharacteristic(Strength, Dexterity, Intelligence, Constitution);
        public Сharacteristic Сharacts
        {
            get { return characts; }
        }

        protected int ExtraPoint = 500;
    }
}
