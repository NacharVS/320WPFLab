using System.Windows;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Core.AppCore core = new Core.AppCore();
        Core.BaseUnit unit = new Core.BaseUnit();
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
            UnitType.Content = unit.Health.ToString();
        }
    }
}
