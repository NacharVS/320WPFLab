using System;
using System.Collections.Generic;
using System.Text;
using static BaseEmptyApp.Logics.Logic;

namespace BaseEmptyApp.Models
{
    internal class Mage : Character
    {
        public override int Strength
        {
            get => base.Strength;
            set
            {
                if (value <= 45 && value >= 15)
                    base.Strength = value;
                else if (value > 45)
                    base.Strength = 45;
                else
                    base.Strength = 15;
            }
        }

        public override int Dexterity
        {
            get => base.Dexterity;
            set
            {
                if (value <= 70 && value >= 20)
                    base.Dexterity = value;
                else if (value > 70)
                    base.Dexterity = 70;
                else
                    base.Dexterity = 20;
            }
        }

        public override int Intelligence
        {
            get => base.Intelligence;
            set
            {
                if (value <= 250 && value >= 30)
                    base.Intelligence = value;
                else if (value > 250)
                    base.Intelligence = 250;
                else
                    base.Intelligence = 30;
            }
        }

        public override int Constitution
        {
            get => base.Constitution;
            set
            {
                if (value <= 65 && value >= 15)
                    base.Constitution = value;
                else if (value > 65)
                    base.Constitution = 65;
                else
                    base.Constitution = 15;
            }
        }

        public Mage()
        {
            ExtraPoint = 5;
            Name = "Mage";
            Strength = 15;
            Dexterity = 20;
            Intelligence = 30;
            Constitution = 15;
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
