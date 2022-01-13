using System;

namespace Core
{
    abstract public class Character
    {
        private string name;
        public string Name { set { name = value; } }

        private int strength;
        public int Strength { get => strength; set { strength = value; } }

        private int dexterity;
        public int Dexterity { get => dexterity; set { dexterity = value; } }

        private int intelligence;
        public int Intelligence { get => intelligence; set { intelligence = value; } }

        private int constitution;
        public int Constitution { get => constitution; set { constitution = value; } }

        private double health;
        public double Health
        {
            get => 2 * Constitution + 0.5 * Strength;
            set { health = value; }
        }

        private double mana;
        public double Mana
        {
            get => Intelligence * 3;
            set { mana = value; }
        }

        private double pAttack;
        public double PAttack
        {
            get => pAttack;
            set { pAttack = value; }
        }

        private double mDefence;
        public double MDefence
        {
            get => mDefence;
            set { mDefence = value; }
        }

        private double mAttack;
        public double MAttack
        {
            get => mAttack;
            set { mAttack = value; }
        }

        private double pCriticalChance;
        public double PCriticalChance
        {
            get => pCriticalChance;
            set { pCriticalChance = value; }
        }

        private double mCriticalChance;
        public double MCriticalChance
        {
            get => mCriticalChance;
            set { mCriticalChance = value; }
        }

        private double pCriticalDamage;
        public double PCriticalDamage
        {
            get => pCriticalDamage;
            set { pCriticalDamage = value; }
        }

        private double mCriticalDamage;
        public double MCriticalDamage
        {
            get => mCriticalDamage;
            set {  mCriticalDamage = value; }
        }
    }
}
