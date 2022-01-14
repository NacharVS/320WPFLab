using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Mage : Character
    {
        public override double minStrength => 15;
        public override double maxStrength => 45;

        public override double minDexterity => 20;
        public override double maxDexterity => 70;

        public override double minIntelligence => 30;
        public override double maxIntelligence => 250;

        public override double minConstitution => 15;
        public override double maxConstitution => 65;
        public Mage()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 30;
            Constitution = 15;
        }
        public override string ToString()
        {
            return "Mage";
        }
    }
}
