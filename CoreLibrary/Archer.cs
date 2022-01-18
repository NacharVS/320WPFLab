using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Archer : Character
    {
        public Archer()
        {
            CharacterType = "Archer";

            minStr = 20;
            maxStr = 55;
            minDex = 30;
            maxDex = 250;
            minInt = 15;
            maxInt = 70;
            minCon = 20;
            maxCon = 70;

            extraPoints = 360;

            maxHealth = 80;
            maxMana = 50;

            Strength = minStr;
            Dexterity = minDex;
            Intelligence = minInt;
            Constitution = minCon;
            Health = maxHealth;
            Mana = maxMana;
        }
    }
}
