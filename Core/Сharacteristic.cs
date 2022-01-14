using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Сharacteristic
    {
        private double m_attack;
        public double M_Attack
        {
            get { return m_attack; }
            set { m_attack = value; }
        }

        private double p_attack;
        public double P_Attack
        {
            get { return p_attack; }
            set { p_attack = value; }
        }

        private double m_defense;
        public double M_defense
        {
            get { return m_defense; }
            set { m_defense = value; }
        }

        private double p_defense;
        public double P_defense
        {
            get { return p_defense; }
            set { p_defense = value; }
        }

        private double m_criticalChance;
        public double M_CriticalChance
        {
            get { return m_criticalChance; }
            set { m_criticalChance = value; }
        }

        private double p_criticalChance;
        public double P_CriticalChance
        {
            get { return p_criticalChance; }
            set { p_criticalChance = value; }
        }

        private double m_criticalDamage;
        public double M_criticalDamage
        {
            get { return m_criticalDamage; }
            set { m_criticalDamage = value; }
        }

        private double p_criticalDamage;
        public double P_criticalDamage
        {
            get { return p_criticalDamage; }
            set { p_criticalDamage = value; }
        }

        public Сharacteristic(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            m_attack = 4 * Intelligence;
            m_defense = 2 * Intelligence;
            m_criticalChance = 20 + 0.1 * Intelligence;
            m_criticalDamage = m_attack * (2 + 0.15 * Intelligence);

            p_attack = 3 * Strength + 0.5 * Dexterity;
            p_defense = 0.5 * Constitution + 3 * Dexterity;
            p_criticalChance = 20 + 0.3 * Constitution;
            p_criticalDamage = p_attack * (2 + 0.05 * Constitution);
        }
    }
}
