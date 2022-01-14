using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    class Player
    {
        public double Strength { get; private set; }
        public double Dexterity { get; private set; }
        public double Intelligence { get; private set; }
        public double Constitution { get; private set; }

        public Player(double str, double dex, double inT, double con)
        {
            Strength = str;
            Dexterity = dex;
            Intelligence = inT;
            Constitution = con;
        }
        public static double Health(double con, double str)
        {
            return 2 * con + 0.5 * str;
        }

        public static double Mana(double inT)
        {
            return inT * 3;
        }
        public static double P_Attack(double str, double dex)
        {

            return str * 3 + 0.5 * dex;
        }
        public static double P_Defense(double con, double dex)
        {
            return con * 0.5 + dex * 3;
        }
        public static double M_Attack(double inT)
        {
            return inT * 4;
        }
        public static double M_Defense(double inT)
        {
            return inT * 2;
        }
        public static double P_Critical_Chanse(double dex)
        {
            return 20 + dex * 0.3;
        }
        public static double M_Critical_Chanse(double inT)
        {
            return 20 + inT * 0.1;
        }
        public static double P_CriticalDamage(double dex, double str)
        {
            return P_Attack(str, dex) * (2 + dex * 0.05);
        }
        public static double M_CriticalDamage(double inT)
        {
            return M_Attack(inT) * (2 + inT * 0.15);
        }
    }

    class Warrior : Player
    {
        public Warrior (double str, double dex, double inT, double con)
            : base (str, dex, inT, con)
        {
            str = 30;
            dex = 15;
            inT = 10;
            con = 25;
        }
    }
    class Mage : Player
    {
        public Mage(double str, double dex, double inT, double con)
            : base(str, dex, inT, con)
        {
            str = 15;
            dex = 20;
            inT = 30;
            con = 15;
        }
    }
    class Archer : Player
    {
        public Archer(double str, double dex, double inT, double con)
            : base(str, dex, inT, con)
        {
            str = 20;
            dex = 30;
            inT = 15;
            con = 20;
        }
    }
}
