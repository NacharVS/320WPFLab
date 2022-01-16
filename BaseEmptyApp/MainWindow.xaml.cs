using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        private static TextBox PB { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            PB = pointBox;
            ChangePage(new Warrior());
        }

        private void WarriorClick(object sender, RoutedEventArgs e)
        {
            ChangePage(new Warrior());
        }

        private void MagicianClick(object sender, RoutedEventArgs e)
        {
            ChangePage(new Magician());
        }

        private void ArcherClick(object sender, RoutedEventArgs e)
        {
            ChangePage(new Archer());
        }

        private void pointBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Case.EP = int.Parse((sender as TextBox).Text);
            }
            catch (Exception) { }
        }

        private void ChangePage(Character character)
        {
            frameCharacter.NavigationService.Navigate(new CharacterPage(character));
        }
    }
}
