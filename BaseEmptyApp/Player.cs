using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    class Player
    {
        double Strength = 0;
        double Dexterity = 0;
        double Intelligence;
        double Constitution;
        double Health;
        double Mana;
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
}
