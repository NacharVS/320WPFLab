using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Character
    {
        public string CharacterType { get; set; }

        public int minStr { get; set; }
        public int maxStr { get; set; }
        public int minDex { get; set; }
        public int maxDex { get; set; }
        public int minInt { get; set; }
        public int maxInt { get; set; }
        public int minCon { get; set; }
        public int maxCon { get; set; }
        public double maxHealth { get; set; }
        public double maxMana { get; set; }

        public double pAttack { get; set; }
        public double mAttack { get; set; }
        public double pDefense { get; set; }
        public double mDefense { get; set; }
        public double pCriticalChanse { get; set; }
        public double mCriticalChanse { get; set; }
        public double pCriticalDamage { get; set; }
        public double mCriticalDamage { get; set; }

        public int extraPoints { get; set; }

        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Constitution { get; set; }
        public double Health { get; set; }
        public double Mana { get; set; }

        public void CalculateStats()
        {
            Health = 2 * (double)Constitution + (double)Strength * 0.5;
            Mana = (double)Intelligence * 3;
            pAttack = (double)Strength * 3 + (double)Dexterity * 0.5;
            mAttack = (double)Intelligence * 4;
            pDefense = (double)Constitution * 0.5 + (double)Dexterity * 3;
            mDefense = (double)Intelligence * 2;
            pCriticalChanse = 20 + (double)Dexterity * 0.3;
            mCriticalChanse = 20 + (double)Intelligence * 0.1;
            pCriticalDamage = pAttack * (2 + (double)Dexterity * 0.05);
            mCriticalDamage = mAttack * (2 + (double)Intelligence * 0.15);
        }

        public void HealthDebaff()
        {
            pAttack *= 0.9;
            mAttack *= 0.9;
            pDefense *= 0.9;
            mDefense *= 0.9;
            pCriticalChanse *= 0.9;
            mCriticalChanse *= 0.9;
            pCriticalDamage *= 0.9;
            mCriticalDamage *= 0.9;
        }

        public void ManaDebaff()
        {
            maxHealth *= 0.8;
        }
    }
}
