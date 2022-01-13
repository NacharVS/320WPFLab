using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG
{
    class Archer
    {
        internal static int strength = 20;
        internal static int dexterity = 30;
        internal static int intelligence = 15;
        internal static int constitution = 20;

        internal static void Strength_addOrTake(int points)
        {
            if (!(strength + points > 55 || strength + points < 20) && Par.points >= points)
            {
                strength += points;

                Par.points -= points;
            }
        }

        internal static void Dexterity_addOrTake(int points)
        {
            if (!(dexterity + points > 250 || dexterity + points < 30) && Par.points >= points)
            {
                dexterity += points;

                Par.points -= points;
            }
        }

        internal static void Intelligence_addOrTake(int points)
        {
            if (!(intelligence + points > 70 || intelligence + points < 15) && Par.points >= points)
            {
                intelligence += points;

                Par.points -= points;
            }
        }

        internal static void Constitution_addOrTake(int points)
        {
            if (!(constitution + points > 70 || constitution + points < 20) && Par.points >= points)
            {
                constitution += points;

                Par.points -= points;
            }
        }
    }
}
