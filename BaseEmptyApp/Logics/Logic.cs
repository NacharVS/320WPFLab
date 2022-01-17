using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Logics
{
    internal class Logic
    {
        internal static double CountPhysAtt(int str, int dex) => str * 3 + 0.5 * dex;
        internal static double CountPhysRes(int con, int dex) => con * 0.5 + 3 * dex;
        internal static double CountMagAtt(int intel) => intel * 4;
        internal static double CountMagRes(int intel) => intel * 2;
        internal static double CountPhysCritChance(int dex) => 20 + dex * 0.3;
        internal static double CountMagCritChance(int intel) => 20 + intel * 0.1;
        internal static double CountPhysCritDmg(double pAttack, int dex) => pAttack * (2 + dex * 0.05);
        internal static double CountMagCritDmg(double mAttack, int intel) => mAttack * (2 + intel * 0.15);
        internal static double CountHealthPoints(int con, int str) => 2 * con + 0.5 * str;
        internal static double CountManaPoints(int intel) => intel * 3;

        internal static void PlusExtraPoints(int stat, int extraPoint)
        {
            if (extraPoint > 0)
            {
                stat++;
                extraPoint--;
            }
            else
                return;
        }

    }
}
