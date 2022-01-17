using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
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
        public abstract double Strength_Minus();
        public abstract double Dexterity_Plus();
        public abstract double Dexterity_Minus();
        public abstract double Intelligence_Plus();
        public abstract double Intelligence_Minus();
        public abstract double Constitution_Plus();
        public abstract double Constitution_Minus();

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

        public double Up_P_Attack(double str, double dex)
        {
            return str * 3 + 0.5 * dex;
        }

        public double Up_P_Defense(double con, double dex)
        {
            return con * 0.5 + dex * 3;
        }

        public double Up_M_Attack(double inT)
        {
            return inT * 4;
        }
        public double Up_M_Defense(double inT)
        {
            return inT * 2;
        }

        public double Up_P_Critical_Chanse(double dex)
        {
            return 20 + dex * 0.3;
        }

        public double Up_M_Critical_Chanse(double inT)
        {
            return 20 + inT * 0.1;
        }

        public double Up_P_CriticalDamage(double p_att, double dex)
        {
            return p_att * (2 + dex * 0.05);
        }

        public double Up_M_CriticalDamage(double m_att, double inT)
        {
            return m_att * (2 + inT * 0.15);
        }

        public double Up_Health(double con, double str)
        {
            return 2 * con + 0.5 * str;
        }

        public double Up_Mana(double inT)
        {
            return inT * 3;
        }
    }

    public class Archer : Player
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
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Strength_Minus()
        {
            if (Strength > str)
            {
                Strength = Strength - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Dexterity_Plus()
        {
            if (Dexterity < max_dex)
            {
                Dexterity = Dexterity + 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Dexterity_Minus()
        {
            if (Dexterity > dex)
            {
                Dexterity = Dexterity - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Intelligence_Plus()
        {
            if (Intelligence < max_inT)
            {
                Intelligence = Intelligence + 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Intelligence_Minus()
        {
            if (Intelligence > inT)
            {
                Intelligence = Intelligence - 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Constitution_Plus()
        {
            if (Constitution < max_con)
            {
                Constitution = Constitution + 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }

        public override double Constitution_Minus()
        {
            if (Constitution > con)
            {
                Constitution = Constitution - 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }
    }

    public class Mage : Player
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
            if (Strength < max_str)
            {
                Strength = Strength + 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Strength_Minus()
        {
            if (Strength > str)
            {
                Strength = Strength - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Dexterity_Plus()
        {
            if (Dexterity < max_dex)
            {
                Dexterity = Dexterity + 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Dexterity_Minus()
        {
            if (Dexterity > dex)
            {
                Dexterity = Dexterity - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Intelligence_Plus()
        {
            if (Intelligence < max_inT)
            {
                Intelligence = Intelligence + 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Intelligence_Minus()
        {
            if (Intelligence > inT)
            {
                Intelligence = Intelligence - 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Constitution_Plus()
        {
            if (Constitution < max_con)
            {
                Constitution = Constitution + 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }

        public override double Constitution_Minus()
        {
            if (Constitution > con)
            {
                Constitution = Constitution - 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }

    }

    public class Warrior : Player
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
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Strength_Minus()
        {
            if (Strength > str)
            {
                Strength = Strength - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                Up_Health(Constitution, Strength);
                return Strength;
            }
            else
            {
                return Strength;
            }
        }

        public override double Dexterity_Plus()
        {
            if (Dexterity < max_dex)
            {
                Dexterity = Dexterity + 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Dexterity_Minus()
        {
            if (Dexterity > dex)
            {
                Dexterity = Dexterity - 1;
                Up_P_Attack(Strength, Dexterity);
                Up_P_Defense(Constitution, Dexterity);
                Up_P_Critical_Chanse(Dexterity);
                Up_P_CriticalDamage(P_Attack, Dexterity);
                return Dexterity;
            }
            else
            {
                return Dexterity;
            }
        }

        public override double Intelligence_Plus()
        {
            if (Intelligence < max_inT)
            {
                Intelligence = Intelligence + 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Intelligence_Minus()
        {
            if (Intelligence > inT)
            {
                Intelligence = Intelligence - 1;
                Up_M_Attack(Intelligence);
                Up_M_Defense(Intelligence);
                Up_M_Critical_Chanse(Intelligence);
                Up_M_CriticalDamage(M_Attack, Intelligence);
                Up_Mana(Intelligence);
                return Intelligence;
            }
            else
            {
                return Intelligence;
            }
        }

        public override double Constitution_Plus()
        {
            if (Constitution < max_con)
            {
                Constitution = Constitution + 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }

        public override double Constitution_Minus()
        {
            if (Constitution > con)
            {
                Constitution = Constitution - 1;
                Up_Health(Constitution, Strength);
                Up_P_Defense(Constitution, Dexterity);
                return Constitution;
            }
            else
            {
                return Constitution;
            }
        }
    }
}
