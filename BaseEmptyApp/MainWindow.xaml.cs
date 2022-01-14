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
            NameTB.Text = warrior.Name;
            StrengthTB.Text = "Strength: " + warrior.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + warrior.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + warrior.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + warrior.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + warrior.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + warrior.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + warrior.Health.ToString();
        }

        private void ChooseMageBtn_Click(object sender, RoutedEventArgs e)
        {
            Mage mage = new Mage();
            NameTB.Text = mage.Name;
            StrengthTB.Text = "Strength: " + mage.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + mage.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + mage.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + mage.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + mage.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + mage.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + mage.Health.ToString();
        }

        private void ChooseArcherBtn_Click(object sender, RoutedEventArgs e)
        {
            Archer archer = new Archer();
            NameTB.Text = archer.Name;
            StrengthTB.Text = "Strength: " + archer.Strength.ToString();
            DexterityTB.Text = "Dexterity: " + archer.Dexterity.ToString();
            PAttackTB.Text = "P. Attack: " + archer.PAttack.ToString();
            PResistTB.Text = "P.Resist: " + archer.PResist.ToString();
            PhysCritChanceTB.Text = "Phys. Crit Chance: " + archer.PhysCritChance.ToString();
            PhysCritDamageTB.Text = "Phys. Crit Damage: " + archer.PhysCritDamage.ToString();
            HealthTB.Text = "Health: " + archer.Health.ToString();
        }
    }
}
