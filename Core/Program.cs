using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Characteristics
    {
        double Strenght;
        double Dexterity;
        double Intelligence;
        double Constitution;
        double Health;
        double Mana;
        double PhyAttack;
        double PhyDefence;
        double MagAttack;
        double MagDefence;
        double PhyCriChance;
        double MagCriChance;
        double PhyCriDam;
        double MagCriDam;

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
            if(Mana < Mana * 0.2)
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
