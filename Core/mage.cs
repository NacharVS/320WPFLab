using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class mage
    {
        public mage(double strength, double dexterity, double intelligence, double constitution)
        {
            HeroClass heroClass = HeroClass.mage;

            int Min_Strenght = 20;
            int Min_Dexterity = 30;
            int Min_Intelligence = 15;
            int Min_Constitution = 20;

            int Max_Strenght = 55;
            int Max_Dexterity = 250;
            int Max_Intelligence = 70;
            int Max_Constitution = 70;

            if (strength < Max_Strenght || strength > Min_Strenght)
            {
                this.Strength = strength;
            }
            else if (dexterity < Max_Dexterity || dexterity > Min_Dexterity)
            {
                this.Dexterity = dexterity;
            }
            else if (intelligence < Max_Intelligence || intelligence > Min_Intelligence)
            {
                this.Intelligence = intelligence;
            }
            else if (constitution < Max_Constitution || constitution > Min_Constitution)
            {
                this.Constitution = constitution;
            }
        }
    }
}
