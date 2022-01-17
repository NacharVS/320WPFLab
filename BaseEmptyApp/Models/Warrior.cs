using System;
using System.Collections.Generic;
using System.Text;
using static BaseEmptyApp.Logics.Logic;

namespace BaseEmptyApp.Models
{
    internal class Warrior : Character
    {
        public override double Strength
        { 
            get => base.Strength;
            set 
            {
                if (value <= 250 && value >= 30)
                    base.Strength = value;
                else if (value > 250)
                    base.Strength = 250;
                else
                    base.Strength = 30;
            }
        }

        public override double Dexterity
        {
            get => base.Dexterity;
            set 
            {
                if(value <= 80 && value >= 15)
                    base.Strength = value;
                else if (value > 80)
                    base.Strength = 80;
                else
                    base.Strength = 15;
            } 
        }

        public override double Intelligence
        {
            get => base.Intelligence;
            set
            {
                if (value <= 50 && value >= 10)
                    base.Intelligence = value;
                else if (value > 50)
                    base.Intelligence = 50;
                else
                    base.Intelligence = 10;
            }
        }

        public override double Constitution
        {
            get => base.Constitution;
            set
            {
                if (value <= 100 && value >= 25)
                    base.Constitution = value;
                else if (value > 100)
                    base.Constitution = 100;
                else
                    base.Constitution = 25;
            }
        }

        public Warrior()
        {
            Name = "Warrior";
            Strength = 30;
            Dexterity = 15;
            Intelligence = 10;
            Constitution = 25;
            Health = CountHealthPoints(Constitution, Strength);
            Mana = CountManaPoints(Intelligence);
            PAttack = CountPhysAtt(Strength, Dexterity);
            MAttack = CountMagAtt(Intelligence);
            PResist = CountPhysRes(Constitution, Dexterity);
            MResist = CountMagRes(Intelligence);
            PhysCritChance = CountPhysCritChance(Dexterity);
            PhysCritDamage = CountPhysCritDmg(PAttack, Dexterity);
            MagCritChance = CountMagCritChance(Intelligence);
            MagCritDamage = CountMagCritDmg(MAttack, Intelligence);
        }
    }
}
