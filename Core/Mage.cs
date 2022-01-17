using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Mage : Character
    {
        public Mage()
        {
            this.Name = "Mage";

            Strength = 15;
            this._minStrength = 15;
            this._maxStrength = 45;

            Dexterity = 20;
            this._minDexterity = 20;
            this._maxDexterity = 70;

            Intelligence = 30;
            this._minIntelligence = 30;
            this._maxIntelligence = 250;

            Constitution = 15;
            this._minConstitution = 15;
            this._maxConstitution = 65;

            this._extrapoints = 100;

            Refresh();
        }
    }
}
