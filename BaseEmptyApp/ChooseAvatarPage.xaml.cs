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
using BaseEmptyApp.Classes;
using BaseEmptyApp.Core.Classes;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для ChooseAvatarPage.xaml
    /// </summary>
    public partial class ChooseAvatarPage : Page
    {
        public ChooseAvatarPage()
        {
            InitializeComponent();
        }

        private void chooseWarrior_Click(object sender, RoutedEventArgs e)
        {
            Warrior person = new Warrior();
            NavigationService.Navigate(new RedactPerson(person));
        }

        private void ChooseMage_Click(object sender, RoutedEventArgs e)
        {
            Mage person = new Mage();
            NavigationService.Navigate(new RedactPerson(person));
        }

        private void chooseArcher_Click(object sender, RoutedEventArgs e)
        {
            Archer person = new Archer();
            NavigationService.Navigate(new RedactPerson(person));
        }
    }
}
