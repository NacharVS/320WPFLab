using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Logics
{
    internal class Logic
    {
        internal static double CountPhysAtt(double str, double dex) => str * 3 + 0.5 * dex;
        internal static double CountPhysRes(double con, double dex) => con * 0.5 + 3 * dex;
        internal static double CountMagAtt(double intel) => intel * 4;
        internal static double CountMagRes(double intel) => intel * 2;
        internal static double CountPhysCritChance(double dex) => 20 + dex * 0.3;
        internal static double CountMagCritChance(double intel) => 20 + intel * 0.1;
        internal static double CountPhysCritDmg(double pAttack, double dex) => pAttack * (2 + dex * 0.05);
        internal static double CountMagCritDmg(double mAttack, double intel) => mAttack * (2 + intel * 0.15);
        internal static double CountHealthPoints(double con, double str) => 2 * con + 0.5 * str;
        internal static double CountManaPoints(double intel) => intel * 3;
    }
}
