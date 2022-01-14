using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    class MagicStats
    {
        public static double MagicAttack(int Intelligence)
        {
            return Intelligence * 3;
        }

        public static double MagicDefense(int Intelligence)
        {
            return Intelligence * 2;
        }

        public static double MagicCriticalChanse(int Intelligence)
        {
            return 20 + Intelligence * 0.1;
        }

        public static double MagicCriticalDamage(double MagicAttackDouble, int Intelligence)
        {
            return MagicAttackDouble * (2 + Intelligence * 0.15);
        }
    }
}
