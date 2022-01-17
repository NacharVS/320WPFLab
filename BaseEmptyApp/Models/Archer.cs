using System;
using System.Collections.Generic;
using System.Text;
using static BaseEmptyApp.Logics.Logic;
namespace BaseEmptyApp.Models
{
    internal class Archer : Character
    {
        public override int Strength
        {
            get => base.Strength;
            set
            {
                if (value <= 55 && value >= 20)
                    base.Strength = value;
                else if (value > 55)
                    base.Strength = 55;
                else
                    base.Strength = 20;
            }
        }

        public override int Dexterity
        {
            get => base.Dexterity;
            set
            {
                if (value <= 250 && value >= 30)
                    base.Dexterity = value;
                else if (value > 250)
                    base.Dexterity = 250;
                else
                    base.Dexterity = 30;
            }
        }

        public override int Intelligence
        {
            get => base.Intelligence;
            set
            {
                if (value <= 70 && value >= 15)
                    base.Intelligence = value;
                else if (value > 70)
                    base.Intelligence = 70;
                else
                    base.Intelligence = 15;
            }
        }

        public override int Constitution
        {
            get => base.Constitution;
            set
            {
                if (value <= 70 && value >= 20)
                    base.Constitution = value;
                else if (value > 70)
                    base.Constitution = 70;
                else
                    base.Constitution = 20;
            }
        }

        public Archer()
        {
            ExtraPoint = 5;
            Name = "Archer";
            Strength = 20;
            Dexterity = 30;
            Intelligence = 15;
            Constitution = 20;
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
