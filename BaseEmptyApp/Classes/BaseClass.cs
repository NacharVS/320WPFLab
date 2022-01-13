using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Classes
{
     class BaseClass
    {
        public double Health;
        public double Mana;

        public static int MinStrenght;
        public static int MinDexterity;
        public static int MinIntelligance;
        public static int MinConstitution;

        public int Strenght = MinStrenght;
        public int Dexterity = MinDexterity;
        public int Intelligance = MinIntelligance;
        public int Constitution = MinConstitution;

        public int MaxStrenght;
        public int MaxDexterity;
        public int MaxIntelligance;
        public int MaxConstitution;
    }
}
