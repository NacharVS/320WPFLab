using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Archer : Character
    {
        public Archer()
        {
            this.Name = "Archer";

            Strength = 20;
            this._minStrength = 20;
            this._maxStrength = 55;

            Dexterity = 30;
            this._minDexterity = 30;
            this._maxDexterity = 250;

            Intelligence = 15;
            this._minIntelligence = 15;
            this._maxIntelligence = 70;

            Constitution = 20;
            this._minConstitution = 20;
            this._maxConstitution = 70;

            this._extrapoints = 100;

            Refresh();
        }
    }
}
