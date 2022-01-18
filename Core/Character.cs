using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public abstract class Character
    { 
        public double Strength { get; protected set; }
        public double Dexterity { get; protected set; }
        public double Intelligence { get; protected set; }
        public double Constitution { get; protected set; }
        public double Health { get; protected set; }
        public double MaxHealth { get; protected set; }
        public double Mana { get; protected set; }

        

        public Character(int s, int d, int i, int c)
        {
            Strength = s;
            Dexterity = d;
            Intelligence = i;
            Constitution = c;
            MaxHealth = Constitution * 2 + Strength + 0.5;
            Health = MaxHealth;
            Mana = Intelligence * 3;
        }
        public void SetHealthPoints(int hp)
        {
            this.Health = hp;
        }
        public void DoIfLowHitPoints()
        {
            Strength = Strength * 0.9;
            Dexterity = Dexterity * 0.9;
            Intelligence = Intelligence * 0.9;
            Constitution = Constitution * 0.9;
        }
        public void DoIfLowMana()
        {
            MaxHealth = MaxHealth * 0.8;
        }

        public double GetMaxHealth()
        {
            return Constitution * 2 + Strength + 0.5;
        }
        public double GetPhysAttack()
        {
            return Strength * 3 + Dexterity * 0.5;
        }
        public double GetPhysDefense()
        {
            return Constitution * 0.5 + Dexterity * 3;
        }      
        public double GetMagicAttack()
        {
            return Intelligence * 4;
        }
        public double GetMagicDefence()
        {
            return Intelligence * 2;
        }
        public double GetPhysCritChance()
        {
            return 20 + Dexterity * 0.3;
        }
        public double GetMagicCritChance()
        {
            return 20 + Intelligence * 0.1;
        }
        public double GetPhysCritDamage()
        {
            return GetPhysAttack() * (2 + Dexterity * 0.05);
        }
        public double GetMagicCritDamage()
        {
            return GetMagicAttack() * (2 + Intelligence * 0.15);
        }
    }
}
