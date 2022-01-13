using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Warrior
    {
        internal static int strength = 30;
        internal static int dexterity = 15;
        internal static int intelligence = 10;
        internal static int constitution = 25;

        internal static void Strength_addOrTake(int points)
        {
            if (!(strength + points > 250 || strength + points < 30) && Par.points >= points)
            {
                strength += points;

                Par.points -= points;
            }
        }

        internal static void Dexterity_addOrTake(int points)
        {
            if (!(dexterity + points > 80 || dexterity + points < 15) && Par.points >= points)
            {
                dexterity += points;

                Par.points -= points;
            }
        }

        internal static void Intelligence_addOrTake(int points)
        {
            if (!(intelligence + points > 50 || intelligence + points < 10) && Par.points >= points)
            {
                intelligence += points;

                Par.points -= points;
            }
        }

        internal static void Constitution_addOrTake(int points)
        {
            if (!(constitution + points > 100 || constitution + points < 25) && Par.points >= points)
            {
                constitution += points;

                Par.points -= points;
            }
        }
    }
}
