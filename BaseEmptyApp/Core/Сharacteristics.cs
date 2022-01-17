using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class Сharacteristics
    {
        public static double GetHealth(int Constitution, int Strenght)
        {
            return 2 * Constitution + 0.5 * Strenght;
        }

        public static double GetMana(int Intelligance)
        {
            return Intelligance * 3;
        }
    }
}
