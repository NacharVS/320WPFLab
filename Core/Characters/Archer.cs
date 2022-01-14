using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Archer : Character
    {
        public Archer(double strength, double dexterity, double intelligence, double constitution)
        {
            HeroClass heroClass = HeroClass.Archer;

            int Min_Strength = 20;
            int Min_Dexterity = 30;
            int Min_Intelligence = 15;
            int Min_Constitution = 20;

            int Max_Strength = 55;
            int Max_Dexterity = 250;
            int Max_Intelligence = 70;
            int Max_Constitution = 70;

            if (strength < Max_Strength || strength > Min_Strength)
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
