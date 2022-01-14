using System;
using System.Collections.Generic;
using System.Text;

namespace Core
{
    class Mage : Character
    {
        public int minS = 15;
        public int minD = 20;
        public int minI = 30;
        public int minC = 15;
        public int maxS = 45;
        public int maxD = 70;
        public int maxI = 250;
        public int maxC = 65;
        public Mage(double strength, double dexterity, double intelligence, double constitution) : base(strength, dexterity, intelligence, constitution)
        {
            strength = this.strength;
            dexterity = this.dexterity;
            intelligence = this.intelligence;
            constitution = this.constitution;
        }
        public void MaloHP()
        {
            if (GetHp() < GetHp() * 0.5)
            {
                HPMalo();
            }
        }
        public double GetManaWarrior()
        {
            if (GetMana() < 0.2 * GetMana())
                return Health *= 0.8;
            return Health;
        }
        public double CheckPAttack()
        {
            if (this.strength < maxS && this.strength > minS && this.dexterity < maxD && this.dexterity > minD)
                return PhysicalAttack();
            return 0;
        }
        public double CheckPDef()
        {
            if (this.constitution < maxC && this.constitution > minC && this.dexterity < maxD && this.dexterity > minD)
                return PhysicalDef();
            return 0;
        }
        public double CheckMAttack()
        {
            if (this.intelligence < maxI && this.intelligence > minI)
                return MagicAttack();
            return 0;
        }
        public double CheckMDef()
        {
            if (this.intelligence < maxI && this.intelligence > minI)
                return MagicAttack();
            return 0;
        }
        public double CheckPCritChance()
        {
            if (this.dexterity < maxD && this.dexterity > minD)
                return PCritChance();
            return 0;
        }
        public double CheckMCritChance()
        {
            if (this.intelligence < maxI && this.intelligence > minI)
                return MCritChance();
            return 0;
        }
        public double CheckPCritDamage()
        {
            if (this.strength < maxS && this.strength > minS && this.dexterity < maxD && this.dexterity > minD)
                return PCritDamage();
            return 0;
        }
        public double CheckMCritDamage()
        {
            if (this.intelligence < maxI && this.intelligence > minI)
                return MCritDamage();
            return 0;
        }
    }
}
