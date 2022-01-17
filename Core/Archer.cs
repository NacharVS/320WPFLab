using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Character
    {
        public Archer()
        {
            imgCharacter = @"C:\Users\nasur\Source\Repos\320WPFLab1\BaseEmptyApp\images\archer.jpg";

            MinStrength = 20;
            MaxStrength = 55;

            MinDexterity= 30;
            MaxDexterity= 250;

            MinIntelligence = 15;
            MaxIntelligence= 70;

            MinConstitution= 20;
            MaxConstitution= 70;

            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
        }
    }
}
