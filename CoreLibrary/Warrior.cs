using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLibrary
{
    public class Warrior : Character
    {
        public Warrior()
        {
            CharacterType = "Warrior";

            minStr = 30;
            maxStr = 250;
            minDex = 15;
            maxDex = 80;
            minInt = 10;
            maxInt = 50;
            minCon = 25;
            maxCon = 100;

            extraPoints = 400;

            maxHealth = 100;
            maxMana = 30;

            Strength = minStr;
            Dexterity = minDex;
            Intelligence = minInt;
            Constitution = minCon;
            Health = maxHealth;
            Mana = maxMana;
        }
    }

}
