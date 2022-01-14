using System;
using System.Collections.Generic;
using System.Text;

namespace CharacterLibrary
{
    public class Warrior:Character
    {
        public override double minStrength => 30;
        public override double maxStrength => 250;

        public override double minDexterity => 15;
        public override double maxDexterity => 80;

        public override double minIntelligence => 10;
        public override double maxIntelligence => 50;

        public override double minConstitution => 25;
        public override double maxConstitution => 100;
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
        }
        public override string ToString()
        {
            return "Warrior";
        }
    }
}
