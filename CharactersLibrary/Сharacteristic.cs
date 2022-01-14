using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Units
{
    public abstract class Сharacteristic
    {
        private double _attack;
        public double Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        private double _defense;
        public double Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        private double _criticalChance;
        public double CriticalChance
        {
            get { return _criticalChance; }
            set { _criticalChance = value; }
        }

        private double _criticalDamage;
        public double CriticalDamage
        {
            get { return _criticalDamage; }
            set { _criticalDamage = value; }
        }

        public override string ToString()
        {
            return $"{Attack} {Defense} {CriticalChance} {CriticalDamage}";
        }
    }
}
