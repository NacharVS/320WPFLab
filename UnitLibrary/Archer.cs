using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Archer : Character
    {
        public override double minStrength => 20;
        public override double maxStrength => 55;

        public override double minDexterity => 30;
        public override double maxDexterity => 250;

        public override double minIntelligence => 15;
        public override double maxIntelligence => 70;

        public override double minConstitution => 20;
        public override double maxConstitution => 70;
        public Archer()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
        }
        public override string ToString()
        {
            return "Archer";
        }
    }
}
