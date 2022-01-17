using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    public class Warrior : Character
    {
        public Warrior()
        {
            this.Name = "Warrior";

            Strength = 30;
            this._minStrength = 30;
            this._maxStrength = 250;

            Dexterity = 15;
            this._minDexterity = 15;
            this._maxDexterity = 80;

            Intelligence = 10;
            this._minIntelligence = 10;
            this._maxIntelligence = 50;

            Constitution = 25;
            this._minConstitution = 25;
            this._maxConstitution = 100;

            this._extrapoints = 100;

            Refresh();
        }
    }
}
