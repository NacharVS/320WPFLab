using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core.AppCore core = new Core.AppCore();
        Core.BaseUnit unit = new Core.BaseUnit();
        ImageSourceConverter converter = new ImageSourceConverter();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void cmBoxUnits_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            ComboBoxItem cbi = (ComboBoxItem)cmBoxUnits.SelectedItem;
            string selectedText = cbi.Content.ToString();
            switch (selectedText)
            {
                case "Warrior":
                    unit = core.MakeWarrior();
                    break;
                case "Mage":
                    unit = core.MakeMage();
                    break;
                case "Archer":
                    unit = core.MakeArcher();
                    break;
            }
            FillTable(unit);
        }

        private void FillTable(Core.BaseUnit unit)
        {
            Strength.Content = unit.Strength.ToString();
            Dexterity.Content = unit.Dexterity.ToString();
            Intelligence.Content = unit.Dexterity.ToString();
            Constitution.Content = unit.Constitution.ToString();
            ePoints.Content = unit.ExtraPoint.ToString();

            Health.Text = unit.Health.ToString();
            Mana.Text = unit.Mana.ToString();

            Attack.Text = unit.Physic.Attack.ToString();
            Defence.Text = unit.Physic.Defense.ToString();
            critChanse.Text = unit.Physic.CriticalChance.ToString();
            critDamage.Text = unit.Physic.CriticalDamage.ToString();
        }

        private void btnSPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpStrength(ref unit);
            FillTable(unit);
        }

        private void btnDPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpDexterity(ref unit);
            FillTable(unit);
        }

        private void btnIPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpIntelligence(ref unit);
            FillTable(unit);
        }

        private void btnCPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpConstitution(ref unit);
            FillTable(unit);
        }

        private void btnDMinus_Click(object sender, RoutedEventArgs e)
        {
            core.DownDexterity(ref unit);
            FillTable(unit);
        }

        private void btnSMinus_Click(object sender, RoutedEventArgs e)
        {
            core.DownStrength(ref unit);
            FillTable(unit);
        }

        private void btnIMinus_Click(object sender, RoutedEventArgs e)
        {
            core.DownIntelligence(ref unit);
            FillTable(unit);
        }

        private void btnCMinus_Click(object sender, RoutedEventArgs e)
        {
            core.DownConstitution(ref unit);
            FillTable(unit);
        }

        private void btnEPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpExtraPoints(ref unit);
            FillTable(unit);
        }
    }
}
