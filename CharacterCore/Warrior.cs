using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCore
{
    public class Warrior : Unit
    {
        public override double MinStrength { get; } = 30;
        public override double MaxStrength { get; } = 250;

        public override double MinDexterity { get; } = 15;
        public override double MaxDexterity { get; } = 80;

        public override double MinIntelligence { get; } = 10;
        public override double MaxIntelligence { get; } = 50;

        public override double MinConstitution { get; } = 25;
        public override double MaxConstitution { get; } = 100;
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
        }
    }
}
