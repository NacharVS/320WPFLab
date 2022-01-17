using System;
using System.Collections.Generic;
using System.Text;
using BaseEmptyApp.Core.Classes;

namespace BaseEmptyApp.Core
{
    public class Mage : BaseClass
    {
        public Mage()
        {
            this.imgPath = @"C:\Users\secon\Source\Repos\320WPFLab\BaseEmptyApp\images\ArtHumanMage.jpg"; this.MinStrenght = 15;
            this.MinDexterity = 20;
            this.MinIntelligance = 30;
            this.MinConstitution = 15;

            this.Strenght = MinStrenght;
            this.Dexterity = MinDexterity;
            this.Intelligance = MinIntelligance;
            this.Constitution = MinConstitution;

            this.MaxStrenght = 45;
            this.MaxDexterity = 70;
            this.MaxIntelligance = 250;
            this.MaxConstitution = 65;

            GetCharacteristics();
        }
    }
}
