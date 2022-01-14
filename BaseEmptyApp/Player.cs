using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp
{
    abstract class Player
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

    class Warrior : Player
    {
        double str = 30;
        double dex = 15;
        double inT = 10;
        double con = 25;

        double max_str = 250;
        double max_dex = 80;
        double max_inT = 50;
        double max_con = 100;
        public Warrior(double str, double dex, double inT, double con) : base(str, dex, inT, con)
        {   
        }

        public override double Strength_Plus()
        {
            if (Strength < max_str)
            {
                Strength = Strength + 1;
                return Strength;
            }
            else
            {
                return Strength;
            }
        }
    }

    class Mage : Player
    {
        double str = 15;
        double dex = 20;
        double inT = 30;
        double con = 15;

        double max_str = 45;
        double max_dex = 70;
        double max_inT = 250;
        double max_con = 65;
        public Mage(double str, double dex, double inT, double con) : base(str, dex, inT, con)
        {
        }
        public override double Strength_Plus()
        {
            if (Strength <max_str)
            {
                Strength = Strength + 1;
                return Strength;
            }
            else
            {
                return Strength;
            }
        }
    }

    class Archer : Player
    {
        double str = 20;
        double dex = 30;
        double inT = 15;
        double con = 20;

        double max_str = 55;
        double max_dex = 250;
        double max_inT = 70;
        double max_con = 70;
        public Archer(double str, double dex, double inT, double con) : base(str, dex, inT, con)
        {
        }
        public override double Strength_Plus()
        {
            if (Strength < max_str)
            {
                Strength = Strength + 1;
                return Strength;
            }
            else
            {
                return Strength;
            }
        }
    }
}
