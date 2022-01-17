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
    /// Логика взаимодействия для PageCharacter.xaml
    /// </summary>
    public partial class PageCharacter : Page
    {
        public Character character { get; set; }
        public PageCharacter(Character newCharacter)
        {
            InitializeComponent();
            character = newCharacter;
            this.DataContext = this;
        }

        private void btnMinusStrengthClick(object sender, RoutedEventArgs e)
        {
            character.Strength -= 1;
            character.Points += 1;
        }

        private void btnMinusDexterityClick(object sender, RoutedEventArgs e)
        {
            character.Dexterity -= 1;
            character.Points += 1;
        }

        private void btnMinusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            character.Intelligence -= 1;
            character.Points += 1;
        }

        private void btnMinusConstitutionClick(object sender, RoutedEventArgs e)
        {
            character.Constitution -= 1;
            character.Points += 1;
        }

        private void btnPlusStrengthClick(object sender, RoutedEventArgs e)
        {
            character.Strength += 1;
            character.Points -= 1;
        }

        private void btnPlusDexterityClick(object sender, RoutedEventArgs e)
        {
            character.Dexterity += 1;
            character.Points -= 1; 
        }

        private void btnPlusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            character.Intelligence += 1;
            character.Points -= 1; 
        }

        private void btnPlusConstitutionClick(object sender, RoutedEventArgs e)
        {
            character.Constitution += 1;
            character.Points -= 1;
        }

        private void btnPlusPointClick(object sender, RoutedEventArgs e)
        {
            character.Points += 1;
        }
    }
}
