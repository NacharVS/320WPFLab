using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public class Warrior : BaseUnit
    {
        public override double MinStrength => 30;
        public override double MaxStrength => 250;
                               
        public override double MinDexterity => 15;
        public override double MaxDexterity => 80;

        public override double MinIntelligence => 10;
        public override double MaxIntelligence => 50;

        public override double MinConstitution => 25;
        public override double MaxConstitution => 100;
        public Warrior()
        {
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
            Image = @"/warrior.png";
        }
    }

    public class Archer : BaseUnit
    {

        public override double MinStrength => 20;
        public override double MaxStrength => 55;
                               
        public override double MinDexterity => 30;
        public override double MaxDexterity => 250;
                               
        public override double MinIntelligence => 15;
        public override double MaxIntelligence => 70;
                               
        public override double MinConstitution => 20;
        public override double MaxConstitution => 70;

        public Archer()
        {
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
        }
    }

    public class Mage : BaseUnit
    {
        public override double MinStrength => 15;
        public override double MaxStrength => 45;
                               
        public override double MinDexterity => 20;
        public override double MaxDexterity => 70;
                               
        public override double MinIntelligence => 30;
        public override double MaxIntelligence => 250;
                               
        public override double MinConstitution => 15;
        public override double MaxConstitution => 65;
        public Mage()
        {
            Strength = 15;
            Dexterity = 20;
            Intelligence = 30;
            Constitution = 15;
            Image = @"../media/img/mage.png";
        }
    }
}
