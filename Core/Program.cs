using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Characteristics
    {
        public enum HeroClass
        {
            Archer,
            Mage,
            Warrior
        }
        double Strenght;
        double Dexterity;
        double Intelligence;
        double Constitution;
        double Health;
        double Mana;
        double PhyAttack { get; set; }
        double PhyDefence { get; set; }
        double MagAttack { get; set; }
        double MagDefence { get; set; }
        double PhyCriChance { get; set; }
        double MagCriChance { get; set; }
        double PhyCriDam { get; set; }
        double MagCriDam { get; set; }

        public void warrior()
        {
            Strenght = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
            Health = Constitution * 2 + Strenght * 0.5;
            if (Health < 0.5 * Health)
            {
                Strenght *= 0.1;
                Dexterity *= 0.1;
                Intelligence *= 0.1;
                Constitution *= 0.1;
            }
            Mana = Intelligence * 3;
            if (Mana < Mana * 0.2)
            {
                Health = Health - Health * 0.2;
            }
        }
        public void mage()
        {

        }
        public void archer()
        {

        }
    }
}
