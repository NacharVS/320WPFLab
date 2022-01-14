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
using CharacterLibrary;

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

        private void BtnMage_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CharacterPage(new Mage()));
        }
        private void BtnWarrior_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CharacterPage(new Warrior()));
        }
        private void BtnArcher_Click(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new CharacterPage(new Archer()));
        }
    }
}
