using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Сharacteristic
    {
        private double _attack;
        protected double Attack
        {
            get { return _attack; }
            set { _attack = value; } 
        }

        private double _defense;
        protected double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        private double _criticalChance;
        protected double CriticalChance
        {
            get { return _criticalChance; }
            set { _criticalChance = value; }
        }

        private double _criticalDamage;
        protected double CriticalDamage
        {
            get { return _criticalDamage; }
            set { _criticalDamage = value; }
        }
        public abstract void Update(int Strength, int Dexterity, int Intelligence, int Constitution);
    }
}
