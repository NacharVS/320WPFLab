using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Character
    {
        public int strength;
        public int dexterity;
        public int intelligence;
        public int constitution;

        public double Health { get; private set; }
        public double Mana { get; private set; }

        public Character(int strength, int dexterity, int intelligence, int constitution)
        {

            this.strength = strength;
            this.dexterity = dexterity;
            this.intelligence = intelligence;
            this.constitution = constitution;

            Health = GetHp();
            Mana = GetMana();
        }

        private double GetHp()
        {
            return (2 * this.constitution + 0.5 * this.strength);
        }

        private double GetMana()
        {
            return (this.intelligence * 3);
        }

        public double PhysicalAttack()
        {
            return (this.strength * 3) + (0.5 * this.dexterity);
        }

        public double PhysicalDef()
        {
            return (this.constitution * 0.5) + (3 * this.dexterity);
        }

        public double MagicAttack()
        {
            return this.intelligence * 4;
        }

        public double MagicDef()
        {
            return this.intelligence * 2;
        }

        public double PCritChance()
        {
            return 20 + this.dexterity * 0.3;
        }

        public double MCritChance()
        {
            return 20 + this.intelligence * 0.1;
        }

        public double PCritDamage()
        {
            return PhysicalAttack() * (2 + this.dexterity * 0.05);
        }

        public double MCritDamage()
        {
            return MagicAttack() * (2 + this.intelligence * 0.15);
        }
    }
}
