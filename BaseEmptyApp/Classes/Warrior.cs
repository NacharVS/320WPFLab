using System;
using System.Collections.Generic;
using System.Text;
using BaseEmptyApp.Classes;

namespace BaseEmptyApp.Classes
{
    class Warrior : BaseClass
    {
        public Warrior()
        {
            this.Strenght = 30;
            this.Dexterity = 15;
            this.Intelligance = 10;
            this.Constitution = 25;
            this.MaxStrenght = 250;
            this.MaxDexterity = 80;
            this.MaxIntelligance = 50;
            this.MaxConstitution = 100;
        }
    }
}
