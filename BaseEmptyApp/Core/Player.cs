using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    public abstract class Player
    {
        public double Strength = 0;
        public double Dexterity = 0;
        public double Intelligence = 0;
        public double Constitution = 0;
        public double P_Attack = 0;
        public double P_Defense = 0;
        public double M_Attack = 0;
        public double M_Defense = 0;
        public double P_Critical_Chanse = 0;
        public double M_Critical_Chanse = 0;
        public double P_CriticalDamage = 0;
        public double M_CriticalDamage = 0;
        public double Health = 0;
        public double Mana = 0;

        public Player(double str, double dex, double inT, double con)
        {
            Strength = str;
            Dexterity = dex;
            Intelligence = inT;
            Constitution = con;
            P_Attack = str * 3 + 0.5 * dex;
            P_Defense = con * 0.5 + dex * 3;
            M_Attack = inT * 4;
            M_Defense = inT * 2;
            P_Critical_Chanse = 20 + dex * 0.3;
            M_Critical_Chanse = 20 + inT * 0.1;
            P_CriticalDamage = P_Attack * (2 + dex * 0.05);
            M_CriticalDamage = M_Attack * (2 + inT * 0.15);
            Health = 2 * con + 0.5 * str;
            Mana = inT * 3;
        }

        public abstract double Strength_Plus();

        public double NewChacarcter()
        {
            return 0;
        }

        //public static double Health(double con, double str)
        //{
        //    return 2 * con + 0.5 * str;
        //}
        //public static double Mana(double inT)
        //{
        //    return inT * 3;
        //}
        //public static double P_Attack(double str, double dex)
        //{
        //    return str * 3 + 0.5 * dex;
        //}
        //public static double P_Defense(double con, double dex)
        //{
        //    return con * 0.5 + dex * 3;
        //}
        //public static double M_Attack(double inT)
        //{
        //    return inT * 4;
        //}
        //public static double M_Defense(double inT)
        //{
        //    return inT * 2;
        //}
        //public static double P_Critical_Chanse(double dex)
        //{
        //    return 20 + dex * 0.3;
        //}
        //public static double M_Critical_Chanse(double inT)
        //{
        //    return 20 + inT * 0.1;
        //}
        //public static double P_CriticalDamage(double dex, double str)
        //{
        //    return P_Attack(str, dex) * (2 + dex * 0.05);
        //}
        //public static double M_CriticalDamage(double inT)
        //{
        //    return M_Attack(inT) * (2 + inT * 0.15);
        //}
    }
}
