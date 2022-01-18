using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Mage : Character
    {
        public Mage()
        {
            CharacterType = "Mage";

            minStr = 15;
            maxStr = 45;
            minDex = 20;
            maxDex = 70;
            minInt = 30;
            maxInt = 250;
            minCon = 15;
            maxCon = 65;

            extraPoints = 350;

            maxHealth = 50;
            maxMana = 80;

            Strength = minStr;
            Dexterity = minDex;
            Intelligence = minInt;
            Constitution = minCon;
            Health = maxHealth;
            Mana = maxMana;
        }
    }
}
