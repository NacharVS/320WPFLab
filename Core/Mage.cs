using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Mage : Character
    {
        public Mage()
        {
            imgCharacter = @"C:\Users\nasur\Source\Repos\320WPFLab1\BaseEmptyApp\images\mage.jpg";

            MinStrength = 15;
            MaxStrength = 45;

            MinDexterity = 20;
            MaxDexterity = 70;

            MinIntelligence = 15;
            MaxIntelligence = 70;

            MinConstitution = 20;
            MaxConstitution = 70;

            Strength = 15;
            Dexterity = 20;
            Intelligence = 15;
            Constitution = 20;
        }
    }
}
