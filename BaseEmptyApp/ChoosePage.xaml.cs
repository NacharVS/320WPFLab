using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Логика взаимодействия для ChoosePage.xaml
    /// </summary>
    public partial class ChoosePage : Page
    {
        public ChoosePage()
        {
            InitializeComponent();
        }

        private void CreateWarrior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new WarriorPage(new Warrior(30, 15, 10, 25)));
        }

        private void CreateMage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MagePage(new Mage(15, 20, 30, 15)));
        }

        private void CreateArcher_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ArcherPage(new Archer(20, 30, 15, 20)));
        }
    }
}
