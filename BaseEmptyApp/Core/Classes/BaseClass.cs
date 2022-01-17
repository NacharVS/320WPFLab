using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core.Classes
{
    public class BaseClass
    {
        public string imgPath;

        public double Health;
        public double Mana;

        public int MinStrenght;
        public int MinDexterity;
        public int MinIntelligance;
        public int MinConstitution;

        public int Strenght;
        public int Dexterity;
        public int Intelligance;
        public int Constitution;

        public int MaxStrenght;
        public int MaxDexterity;
        public int MaxIntelligance;
        public int MaxConstitution;

        public double PhysAttack;
        public double PhysDefense;
        public double PhysCriticalChanse;
        public double PhysCriticalDamage;
        public double MagicCriticalDamage;
        public double MagicAttack;
        public double MagicDefense;
        public double MagicCriticalChanse;

        public void GetCharacteristics()
        {
            this.Health = Сharacteristics.GetHealth(Constitution, Strenght);
            this.Mana = Сharacteristics.GetMana(Intelligance);
            this.PhysAttack = PhysicCharacteristics.PhysicAttack(Strenght, Dexterity);
            this.PhysDefense = PhysicCharacteristics.PhysicDefense(Constitution, Dexterity);
            this.PhysCriticalChanse = PhysicCharacteristics.PhysicCriticalChanse(Dexterity);
            this.PhysCriticalDamage = PhysicCharacteristics.PhysicCriticalDamage(PhysAttack, Dexterity);
            this.MagicAttack = MagicCharacteristics.MagicAttack(Intelligance);
            this.MagicDefense = MagicCharacteristics.MagicDefense(Intelligance);
            this.MagicCriticalChanse = MagicCharacteristics.MagicCriticalChanse(Intelligance);
            this.MagicCriticalDamage = MagicCharacteristics.MagicCriticalDamage(MagicAttack, Intelligance);
        }
        public void StrenghtChange()
        {
            this.Health = Сharacteristics.GetHealth(Constitution, Strenght);
            this.PhysAttack = PhysicCharacteristics.PhysicAttack(Strenght, Dexterity);
        }

        public void DexterityChange()
        {
            this.PhysAttack = PhysicCharacteristics.PhysicAttack(Strenght, Dexterity);
            this.PhysDefense = PhysicCharacteristics.PhysicDefense(Constitution, Dexterity);
            this.PhysCriticalChanse = PhysicCharacteristics.PhysicCriticalChanse(Dexterity);
            this.PhysCriticalDamage = PhysicCharacteristics.PhysicCriticalDamage(PhysAttack, Dexterity);
        }

        public void IntelliganceChange()
        {
            this.Mana = Сharacteristics.GetMana(Intelligance);
            this.MagicAttack = MagicCharacteristics.MagicAttack(Intelligance);
            this.MagicDefense = MagicCharacteristics.MagicDefense(Intelligance);
            this.MagicCriticalChanse = MagicCharacteristics.MagicCriticalChanse(Intelligance);
            this.MagicCriticalDamage = MagicCharacteristics.MagicCriticalDamage(MagicAttack, Intelligance);

        }

        public void ConstitutionChange()
        {
            this.Health = Core.Сharacteristics.GetHealth(Constitution, Strenght);
            this.PhysDefense = PhysicCharacteristics.PhysicDefense(Constitution, Dexterity);
        }
    }
}
