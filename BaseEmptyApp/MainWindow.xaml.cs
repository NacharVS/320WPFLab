using System;
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
        private string chosenChar;
        public MainWindow()
        {
            InitializeComponent();
        }
        
        // Character Creation
        #region
        private void ChooseWarriorBtn_Click(object sender, RoutedEventArgs e)
        {
            Warrior warrior = new Warrior();
            ExtraPointsTB.Text = warrior.ExtraPoint.ToString();
            NameTB.Text = warrior.Name;
            StrengthTB.Text = warrior.Strength.ToString();
            DexterityTB.Text = warrior.Dexterity.ToString();
            PAttackTB.Text = warrior.PAttack.ToString();
            PResistTB.Text = warrior.PResist.ToString();
            PhysCritChanceTB.Text = warrior.PhysCritChance.ToString();
            PhysCritDamageTB.Text = warrior.PhysCritDamage.ToString();
            HealthTB.Text = warrior.Health.ToString();
            IntelligenceTB.Text = warrior.Intelligence.ToString();
            ConstitutionTB.Text = warrior.Constitution.ToString();
            MAttackTB.Text = warrior.MAttack.ToString();
            MResistTB.Text = warrior.MResist.ToString();
            MagCritChanceTB.Text = warrior.PhysCritChance.ToString();
            MagCritDamageTB.Text = warrior.PhysCritDamage.ToString();
            ManaTB.Text = warrior.Mana.ToString();
            chosenChar = warrior.Name;
        }

        private void ChooseMageBtn_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            ExtraPointsTB.Text = mage.ExtraPoint.ToString();
            NameTB.Text = mage.Name;
            StrengthTB.Text = mage.Strength.ToString();
            DexterityTB.Text = mage.Dexterity.ToString();
            PAttackTB.Text = mage.PAttack.ToString();
            PResistTB.Text = mage.PResist.ToString();
            PhysCritChanceTB.Text = mage.PhysCritChance.ToString();
            PhysCritDamageTB.Text = mage.PhysCritDamage.ToString();
            HealthTB.Text = mage.Health.ToString();
            IntelligenceTB.Text = mage.Intelligence.ToString();
            ConstitutionTB.Text = mage.Constitution.ToString();
            MAttackTB.Text = mage.MAttack.ToString();
            MResistTB.Text = mage.MResist.ToString();
            MagCritChanceTB.Text = mage.PhysCritChance.ToString();
            MagCritDamageTB.Text = mage.PhysCritDamage.ToString();
            ManaTB.Text = mage.Mana.ToString();
            chosenChar = mage.Name;
        }

        private void ChooseArcherBtn_Click(object sender, RoutedEventArgs e)
        {
            Archer archer = new Archer();
            ExtraPointsTB.Text = archer.ExtraPoint.ToString();
            NameTB.Text = archer.Name;
            StrengthTB.Text = archer.Strength.ToString();
            DexterityTB.Text = archer.Dexterity.ToString();
            PAttackTB.Text = archer.PAttack.ToString();
            PResistTB.Text = archer.PResist.ToString();
            PhysCritChanceTB.Text = archer.PhysCritChance.ToString();
            PhysCritDamageTB.Text = archer.PhysCritDamage.ToString();
            HealthTB.Text = archer.Health.ToString();
            IntelligenceTB.Text = archer.Intelligence.ToString();
            ConstitutionTB.Text = archer.Constitution.ToString();
            MAttackTB.Text = archer.MAttack.ToString();
            MResistTB.Text = archer.MResist.ToString();
            MagCritChanceTB.Text = archer.PhysCritChance.ToString();
            MagCritDamageTB.Text = archer.PhysCritDamage.ToString();
            ManaTB.Text = archer.Mana.ToString();
            chosenChar = archer.Name;
        }

        #endregion

        //Plus Stats buttons
        #region
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
                StatsValueChange();
            }
            else
                MessageBox.Show("error");
        }

        private void ConstDownBtn_Click(object sender, RoutedEventArgs e)
        {
            int constit = Convert.ToInt32(ConstitutionTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            int minConst;
            switch (chosenChar)
            {
                case "Warrior":
                    minConst = 25; break;
                case "Mage":
                    minConst = 15; break;
                case "Archer":
                    minConst = 20; break;
                default:
                    minConst = 10; break;

            }

            if (constit > minConst && extraPoints >= 0)
            {
                constit--;
                extraPoints++;
                ConstitutionTB.Text = constit.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                return;
        }

        private void PlusExtrtaBtn_Click(object sender, RoutedEventArgs e)
        {
            int extras = Convert.ToInt32(ExtraPointsTB.Text);
            extras += 5;
            ExtraPointsTB.Text = extras.ToString();
        }

        private void IntelUpBtn_Click(object sender, RoutedEventArgs e)
        {
            int intel = Convert.ToInt32(IntelligenceTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            if (extraPoints > 0)
            {
                intel++;
                extraPoints--;
                IntelligenceTB.Text = intel.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                MessageBox.Show("error");
        }

        private void IntelDownBtn_Click(object sender, RoutedEventArgs e)
        {
            int intel = Convert.ToInt32(IntelligenceTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            int minIntel;
            switch (chosenChar)
            {
                case "Warrior":
                    minIntel = 10; break;
                case "Mage":
                    minIntel = 30; break;
                case "Archer":
                    minIntel = 15; break;
                default:
                    minIntel = 10; break;

            }

            if (intel > minIntel && extraPoints >= 0)
            {
                intel--;
                extraPoints++;
                IntelligenceTB.Text = intel.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                return;
        }

        private void StrengthUpBtn_Click(object sender, RoutedEventArgs e)
        {
            int strenght = Convert.ToInt32(StrengthTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            if (extraPoints > 0)
            {
                strenght++;
                extraPoints--;
                StrengthTB.Text = strenght.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                MessageBox.Show("error");
        }

        private void StrengthDownBtn_Click(object sender, RoutedEventArgs e)
        {
            int strength = Convert.ToInt32(StrengthTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            int minStr;
            switch (chosenChar)
            {
                case "Warrior":
                    minStr = 30; break;
                case "Mage":
                    minStr = 15; break;
                case "Archer":
                    minStr = 20; break;
                default:
                    minStr = 10; break;

            }

            if (strength > minStr && extraPoints >= 0)
            {
                strength--;
                extraPoints++;
                StrengthTB.Text = strength.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                return;
        }

        private void DexUpBtn_Click(object sender, RoutedEventArgs e)
        {
            int dex = Convert.ToInt32(DexterityTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            if (extraPoints > 0)
            {
                dex++;
                extraPoints--;
                DexterityTB.Text = dex.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                MessageBox.Show("error");
        }

        private void DexDownBtn_Click(object sender, RoutedEventArgs e)
        {
            int dex = Convert.ToInt32(DexterityTB.Text);
            int extraPoints = Convert.ToInt32(ExtraPointsTB.Text);
            int minDex;
            switch (chosenChar)
            {
                case "Warrior":
                    minDex = 15; break;
                case "Mage":
                    minDex = 20; break;
                case "Archer":
                    minDex = 30; break;
                default:
                    minDex = 10; break;
            }

            if (dex > minDex && extraPoints >= 0)
            {
                dex--;
                extraPoints++;
                DexterityTB.Text = dex.ToString();
                ExtraPointsTB.Text = extraPoints.ToString();
                StatsValueChange();
            }
            else
                return;
        }
        #endregion

        private void StatsValueChange()
        {
            int str = Convert.ToInt32(StrengthTB.Text);
            int dex = Convert.ToInt32(DexterityTB.Text);
            int intel = Convert.ToInt32(IntelligenceTB.Text);
            int constit = Convert.ToInt32(ConstitutionTB.Text);
            HealthTB.Text = CountHealthPoints(constit, str).ToString();
            ManaTB.Text = CountManaPoints(intel).ToString();
            PAttackTB.Text = CountPhysAtt(str, dex).ToString();
            PResistTB.Text = CountPhysRes(constit, dex).ToString();
            MAttackTB.Text = CountMagAtt(intel).ToString();
            MResistTB.Text = CountMagRes(intel).ToString();
            PhysCritChanceTB.Text = CountPhysCritChance(dex).ToString();
            MagCritChanceTB.Text = CountMagCritChance(intel).ToString();
            double physAttack = Convert.ToDouble(PAttackTB.Text);
            PhysCritDamageTB.Text = CountPhysCritDmg(physAttack, dex).ToString();
            double magAttack = Convert.ToDouble(MAttackTB.Text);
            MagCritDamageTB.Text = CountMagCritDmg(magAttack, intel).ToString();
        }
    }
}
