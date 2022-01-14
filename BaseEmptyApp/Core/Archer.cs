using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
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

        public double Up_P_Attack(double str, double dex)
        {
            P_Attack = str * 3 + 0.5 * dex;
            return P_Attack;
        }

        public double Up_P_Defense(double con, double dex)
        {
            P_Defense = con * 0.5 + dex * 3;
            return P_Defense;
        }

        public double Up_M_Attack(double inT)
        {
            M_Defense = inT * 2;
            return M_Defense;
        }

        public double Up_P_Critical_Chanse(double dex)
        {
            P_Critical_Chanse = 20 + dex * 0.3;
            return P_Critical_Chanse;
        }

        public double Up_M_Critical_Chanse(double inT)
        {
            M_Critical_Chanse = 20 + inT * 0.1;
            return M_Critical_Chanse;
        }

        public double Up_P_CriticalDamage(double p_att, double dex)
        {
            P_CriticalDamage = p_att * (2 + dex * 0.05);
            return P_CriticalDamage;
        }

        public double Up_M_CriticalDamage(double m_att, double inT)
        {
            M_CriticalDamage = m_att * (2 + inT * 0.15);
            return M_CriticalDamage;
        }

        public double Up_Health(double con, double str)
        {
            Health = 2 * con + 0.5 * str;
            return Health;
        }

        public double Up_Mana(double inT)
        {
            Mana = inT * 3;
            return Mana;
        }
    }
}
