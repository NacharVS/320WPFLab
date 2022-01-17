using System;
using System.Collections.Generic;
using System.Text;
using BaseEmptyApp.Core.Classes;

namespace BaseEmptyApp.Core
{
    public class Archer : BaseClass
    {
        public Archer()
        {
            this.imgPath = @"C:\Users\danil\Source\Repos\320WPFLab\BaseEmptyApp\images\archer.png";
            this.MinStrenght = 20;
            this.MinDexterity = 30;
            this.MinIntelligance = 15;
            this.MinConstitution = 20;

            this.Strenght = MinStrenght;
            this.Dexterity = MinDexterity;
            this.Intelligance = MinIntelligance;
            this.Constitution = MinConstitution;

            this.MaxStrenght = 55;
            this.MaxDexterity = 250;
            this.MaxIntelligance = 70;
            this.MaxConstitution = 70;

            GetCharacteristics();
        }
    }
}
