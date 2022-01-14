using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public abstract class Statistics
    {
        public abstract void GetCharacteristics(int Strength, int Dexterity, int Intelligence, int Constitution);

        private double attack;
        public double Attack { get => attack; set => attack = value; }

        private double defense;
        public double Defense { get => defense; set => defense = value; }

        private double criticalChanse;
        public double CriticalChanse { get => criticalChanse; set => criticalChanse = value; }

        private double criticalDamage;
        public double CriticalDamage { get => criticalDamage; set => criticalDamage = value; }
    }
}
