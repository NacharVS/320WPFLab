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


    }
}
