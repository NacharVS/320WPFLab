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
using Core;

namespace BaseEmptyApp
{
    public partial class MainWindow : Window
    {
        public static int EP { get; set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void WarriorClick(object sender, RoutedEventArgs e)
        {
            frameCharacter.NavigationService.Navigate(new CharacterPage(new Warrior()));
        }

        private void MagicianClick(object sender, RoutedEventArgs e)
        {
            frameCharacter.NavigationService.Navigate(new CharacterPage(new Magician()));
        }

        private void ArcherClick(object sender, RoutedEventArgs e)
        {
            frameCharacter.NavigationService.Navigate(new CharacterPage(new Archer()));
        }

        private void pointBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                EP = int.Parse((sender as TextBox).Text);
            }
            catch
            {
                (sender as TextBox).Text = EP.ToString();
            }
        }
    }
}
