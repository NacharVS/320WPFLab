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
using BaseEmptyApp.Core;
using BaseEmptyApp.Core.Classes;

namespace BaseEmptyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для ChooseCharacter.xaml
    /// </summary>
    public partial class ChooseCharacter : Page
    {
        public ChooseCharacter()
        {
            InitializeComponent();
        }

        private void chooseWarrior_Click(object sender, RoutedEventArgs e)
        {
            Warrior hero = new Warrior();
            NavigationService.Navigate(new CharacterEditor(hero));
        }

        private void ChooseMage_Click(object sender, RoutedEventArgs e)
        {
            Mage hero = new Mage();
            NavigationService.Navigate(new CharacterEditor(hero));
        }

        private void chooseArcher_Click(object sender, RoutedEventArgs e)
        {
            Archer hero = new Archer();
            NavigationService.Navigate(new CharacterEditor(hero));
        }
    }
}
