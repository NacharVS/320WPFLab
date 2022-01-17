using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Archer : Character
    {
        public override double MinStrength => 20;
        public override double MaxStrength => 55;

        public override double MinDexterity => 30;
        public override double MaxDexterity => 250;

        public override double MinIntelligence => 15;
        public override double MaxIntelligence => 70;

        public override double MinConstitution => 20;
        public override double MaxConstitution => 70;
    }
}
