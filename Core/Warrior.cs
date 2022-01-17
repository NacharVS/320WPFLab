using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Warrior : Character
    {
        public Warrior()
        {
            imgCharacter = @"C:\Users\nasur\Source\Repos\320WPFLab1\BaseEmptyApp\images\warrier.jpg";

            MinStrength = 30;
            MaxStrength = 250;

            MinDexterity = 15;
            MaxDexterity = 80;

            MinIntelligence = 10;
            MaxIntelligence = 50;

            MinConstitution = 25;
            MaxConstitution = 100;

            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
        }
    }
}
