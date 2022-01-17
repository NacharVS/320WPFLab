using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
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
            if (Strength < max_str)
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
            if (Dexterity < max_dex)
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
            if (Intelligence < max_inT)
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
            if (Constitution < max_con)
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
