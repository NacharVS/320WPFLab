using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Mage : Character
    {
        public Mage()
        {
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
            Intelligence = 30;
            Constitution = 20;
        }
    }
}
