using System.Windows;
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

        private void btnWarrior_Click(object sender, RoutedEventArgs e)
        {
            unit = core.MakeWarrior();
            FillData(unit);
        }

        private void btnMage_Click(object sender, RoutedEventArgs e)
        {
            unit = core.MakeMage();
            FillData(unit);
        }

        private void btnArcher_Click(object sender, RoutedEventArgs e)
        {
            unit = core.MakeArcher();
            FillData(unit);
        }

        private void FillData(Core.BaseUnit unit)
        {
            ePoints.Content = unit.ExtraPoint;
            Health.Content = unit.Health;
            Mana.Content = unit.Mana;
            Strenght.Content = unit.Strength;
            Dexterity.Content = unit.Dexterity;
            Intelligence.Content = unit.Intelligence;
            Constitution.Content = unit.Constitution;
        }

        private void sPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpStrength(ref unit);
            FillData(unit);
        }

        private void dPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpDexterity(ref unit);
            FillData(unit);
        }

        private void iPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpIntelligence(ref unit);
            FillData(unit);
        }

        private void cPlus_Click(object sender, RoutedEventArgs e)
        {
            core.UpConstitution(ref unit);
            FillData(unit);
        }
    }
}
