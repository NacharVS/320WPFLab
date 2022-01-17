using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Mage : Character
    {
        public override double MinStrength { get; } = 15;
        public override double MaxStrength { get; } = 45;

        public override double MinDexterity { get; } = 20;
        public override double MaxDexterity { get; } = 70;

        public override double MinIntelligence { get; } = 30;
        public override double MaxIntelligence { get; } = 250;

        public override double MinConstitution { get; } = 15;
        public override double MaxConstitution { get; } = 65;
    }
}
