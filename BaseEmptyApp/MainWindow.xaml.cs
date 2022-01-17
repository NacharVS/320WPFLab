﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BaseEmptyApp.Models;
using static BaseEmptyApp.Logics.Logic;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void ChooseWarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            ExtraPointsTB.Text = warrior.ExtraPoint.ToString();
            NameTB.Text = warrior.Name;
            StrengthTB.Text = "Strength: " + warrior.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + warrior.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + warrior.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + warrior.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + warrior.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + warrior.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + warrior.Health.ToString();
            IntelligenceTB.Text = "Intelligence: " + warrior.Intelligence.ToString();
            ConstitutionTB.Text = "Constitution: " + warrior.Constitution.ToString();
            MAttackTB.Text = "M. Attack: " + warrior.MAttack.ToString();
            MResistTB.Text = "M. Resist: " + warrior.MResist.ToString();
            MagCritChanceTB.Text = "M. Crit Chance: " + warrior.PhysCritChance.ToString();
            MagCritDamageTB.Text = "M. Crit Damage: " + warrior.PhysCritDamage.ToString();
            ManaTB.Text = "Mana: " + warrior.Mana.ToString();
        }

        private void ChooseMageBtn_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            ExtraPointsTB.Text = mage.ExtraPoint.ToString();
            NameTB.Text = mage.Name;
            StrengthTB.Text = "Strength: " + mage.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + mage.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + mage.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + mage.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + mage.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + mage.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + mage.Health.ToString();
            IntelligenceTB.Text = "Intelligence: " + mage.Intelligence.ToString();
            ConstitutionTB.Text = "Constitution: " + mage.Constitution.ToString();
            MAttackTB.Text = "M. Attack: " + mage.MAttack.ToString();
            MResistTB.Text = "M. Resist: " + mage.MResist.ToString();
            MagCritChanceTB.Text = "M. Crit Chance: " + mage.PhysCritChance.ToString();
            MagCritDamageTB.Text = "M. Crit Damage: " + mage.PhysCritDamage.ToString();
            ManaTB.Text = "Mana: " + mage.Mana.ToString();
        }

        private void ChooseArcherBtn_Click(object sender, RoutedEventArgs e)
        {
            Archer archer = new Archer();
            ExtraPointsTB.Text = archer.ExtraPoint.ToString();
            NameTB.Text = archer.Name;
            StrengthTB.Text = "Strength: " + archer.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + archer.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + archer.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + archer.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + archer.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + archer.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + archer.Health.ToString();
            IntelligenceTB.Text = "Intelligence: " + archer.Intelligence.ToString();
            ConstitutionTB.Text = archer.Constitution.ToString();
            MAttackTB.Text = "M. Attack: " + archer.MAttack.ToString();
            MResistTB.Text = "M. Resist: " + archer.MResist.ToString();
            MagCritChanceTB.Text = "M. Crit Chance: " + archer.PhysCritChance.ToString();
            MagCritDamageTB.Text = "M. Crit Damage: " + archer.PhysCritDamage.ToString();
            ManaTB.Text = "Mana: " + archer.Mana.ToString();
        }

        private void ConstUpBtn_Click(object sender, RoutedEventArgs e)
        {
            int constit = Convert.ToInt32(ConstitutionTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            if (extraPoints > 0)
            {
                constit++;
                extraPoints--;
                ConstitutionTB.Text = constit.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
            }
            else
                MessageBox.Show("error");
        }

        private void ConstDownBtn_Click(object sender, RoutedEventArgs e)
        {
            //int constit = Convert.ToInt32(ConstitutionTB.Text);
            //int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            //constit--;
            //extraPoints++;
            //if()
        }
    }
}
