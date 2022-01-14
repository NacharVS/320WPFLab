using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCore
{
    public class Archer : Unit
    {
        public override double MinStrength { get; } = 20;
        public override double MaxStrength { get; } = 55;

        public override double MinDexterity { get; } = 30;
        public override double MaxDexterity { get; } = 250;

        public override double MinIntelligence { get; } = 15;
        public override double MaxIntelligence { get; } = 70;

        public override double MinConstitution { get; } = 20;
        public override double MaxConstitution { get; } = 70;
        public Archer()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
        }
    }
}
