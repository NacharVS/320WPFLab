using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Warrior : Character
    {
        public Warrior(double strength, double dexterity, double intelligence, double constitution)
        {
            HeroClass heroClass = HeroClass.Warrior;

            int Min_Strength = 30;
            int Min_Dexterity = 15;
            int Min_Intelligence = 10;
            int Min_Constitution = 25;

            int Max_Strength = 250;
            int Max_Dexterity = 80;
            int Max_Intelligence = 50;
            int Max_Constitution = 100;

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
