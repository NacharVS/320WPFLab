using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    internal abstract class Character
    {
        private string name;
        public string Name
        {
            set
            {
                name = value;
            }
        }

        private int strength { get; set; }
        public int Strength
        {
            get => strength;
            set
            {
                strength = value;
            }
        }

        private int dexterity { get; set; }
        public int Dexterity
        {
            get => dexterity;
            set
            {
                dexterity = value;
            }
        }

        private int intelligence { get; set; }
        public int Intelligence
        {
            get => intelligence;
            set
            {
                intelligence = value;
            }
        }

        private int constitution { get; set; }
        public int Constitution
        {
            get => constitution;
            set
            {
                constitution = value;
            }
        }

        private int health { get; set; }
        public int Health
        {
            get => health;
            set
            {
                health = value;
            }
        }

        private int mana { get; set; }
        public int Mana
        {
            get => mana;
            set
            {
                mana = value;
            }
        }

        private int pAttack { get; set; }
        public int PAttack
        {
            get => pAttack;
            set
            {
                pAttack = value;
            }
        }

        private int mDefence { get; set; }
        public int MDefence
        {
            get => mDefence;
            set
            {
                mDefence = value;
            }
        }

        private int mAttack { get; set; }
        public int MAttack
        {
            get => mAttack;
            set
            {
                mAttack = value;
            }
        }

        private int pCriticalChance { get; set; }
        public int PCriticalChance
        {
            get => pCriticalChance;
            set
            {
                pCriticalChance = value;
            }
        }

        private int mCriticalChance { get; set; }
        public int MCriticalChance
        {
            get => mCriticalChance;
            set
            {
                mCriticalChance = value;
            }
        }

        private int pCriticalDamage { get; set; }
        public int PCriticalDamage
        {
            get => pCriticalDamage;
            set
            {
                pCriticalDamage = value;
            }
        }

        private int mCriticalDamage { get; set; }
        public int MCriticalDamage
        {
            get => mCriticalDamage;
            set
            {
                mCriticalDamage = value;
            }
        }
    }
}
