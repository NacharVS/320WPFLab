using System;
using System.Collections.Generic;
using System.Text;
using  BaseEmptyApp.Core;

namespace BaseEmptyApp.Classes
{

    public class BaseClass
     {
        public string imgSource;

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

        public double PAttack;
        public double PDefense;
        public double MAttack;
        public double MDefense;
        public double PCriticalChanse;
        public double MCriticalChanse;
        public double PCriticalDamage;
        public double MCriticalDamage;

        public BaseClass()
        {
            
        }

        public void getStats()
        {
            this.Health = HealthAndMana.GetHealth(Constitution, Strenght);
            this.Mana = HealthAndMana.GetMana(Intelligance);
            this.PAttack = PhysicalStats.PhysAttack(Strenght, Dexterity);
            this.PDefense = PhysicalStats.PhysDefense(Constitution, Dexterity);
            this.PCriticalChanse = PhysicalStats.PhysCriticalChanse(Dexterity);
            this.PCriticalDamage = PhysicalStats.PhysCriticalDamage(PAttack, Dexterity);
            this.MAttack = MagicStats.MagicAttack(Intelligance);
            this.MDefense = MagicStats.MagicDefense(Intelligance);
            this.MCriticalChanse = MagicStats.MagicCriticalChanse(Intelligance);
            this.MCriticalDamage = MagicStats.MagicCriticalDamage(MAttack, Intelligance);
        }
        public void StrenghtChange()
        {
            this.Health = HealthAndMana.GetHealth(Constitution, Strenght);
            this.PAttack = PhysicalStats.PhysAttack(Strenght, Dexterity);
        }

        public void DexterityChange()
        {
            this.PAttack = PhysicalStats.PhysAttack(Strenght, Dexterity);
            this.PDefense = PhysicalStats.PhysDefense(Constitution, Dexterity);
            this.PCriticalChanse = PhysicalStats.PhysCriticalChanse(Dexterity);
            this.PCriticalDamage = PhysicalStats.PhysCriticalDamage(PAttack, Dexterity);
        }

        public void IntelliganceChange()
        {
            this.Mana = HealthAndMana.GetMana(Intelligance);
            this.MAttack = MagicStats.MagicAttack(Intelligance);
            this.MDefense = MagicStats.MagicDefense(Intelligance);
            this.MCriticalChanse = MagicStats.MagicCriticalChanse(Intelligance);
            this.MCriticalDamage = MagicStats.MagicCriticalDamage(MAttack, Intelligance);

        }

        public void ConstitutionChange()
        {
            this.Health = HealthAndMana.GetHealth(Constitution, Strenght);
            this.PDefense = PhysicalStats.PhysDefense(Constitution, Dexterity);
        }


     }
}
