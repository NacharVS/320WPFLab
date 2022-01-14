using Core;
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

namespace BaseEmptyApp
{
    public partial class pageClasses : Page
    {
        public pageClasses()
        {
            InitializeComponent();
        }

        private void Archer_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pageMain(new Archer()));
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pageMain(new Warrior()));
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new pageMain(new Mage()));
        }
    }
}
