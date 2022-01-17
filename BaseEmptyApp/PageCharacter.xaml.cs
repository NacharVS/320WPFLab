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
        Character character { get; set; }
        public PageCharacter(Character newCharacter)
        {
            InitializeComponent();
            character = newCharacter;
            UpdateStats();
        }

        private void EditCharecteristic(int s, int d, int i, int c, int p)
        {
            try
            {
                character.Strength += s;
                character.Dexterity += d;
                character.Intelligence += i;
                character.Constitution += c;
                character.Points += p;
                UpdateStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStats()
        {
            tbPoints.Text = character.Points.ToString();

            tbStrength.Text = character.Strength.ToString();
            tbDexterity.Text = character.Dexterity.ToString();
            tbIntelligence.Text = character.Intelligence.ToString();
            tbConstitution.Text = character.Constitution.ToString();

            tbHealth.Text = character.Health.ToString();
            tbMana.Text = character.Mana.ToString();

            tbPAttack.Text = character.Physic.Attack.ToString();
            tbPDefense.Text = character.Physic.Defense.ToString();
            tbMAttack.Text = character.Magic.Attack.ToString();
            tbMDefense.Text = character.Magic.Defense.ToString();
            tbPCriticalChance.Text = character.Physic.CriticalChance.ToString();
            tbMCriticalChance.Text = character.Magic.CriticalChance.ToString();
            tbPCriticalDamage.Text = character.Physic.CriticalDamage.ToString();
            tbMCriticalDamage.Text = character.Magic.CriticalDamage.ToString();
        }

        private void btnMinusStrengthClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(-1, 0, 0, 0, 1);
            UpdateStats();
        }

        private void btnMinusDexterityClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, -1, 0, 0, 1);
            UpdateStats();
        }

        private void btnMinusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 0, -1, 0, 1);
            UpdateStats();
        }

        private void btnMinusConstitutionClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 0, 0, -1, 1);
            UpdateStats();
        }

        private void btnPlusStrengthClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(1, 0, 0, 0, -1);
            UpdateStats();
        }

        private void btnPlusDexterityClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 1, 0, 0, -1);
            UpdateStats();
        }

        private void btnPlusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 0, 1, 0, -1);
            UpdateStats();
        }

        private void btnPlusConstitutionClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 0, 0, 1, -1);
            UpdateStats();
        }

        private void btnPlusPointClick(object sender, RoutedEventArgs e)
        {
            EditCharecteristic(0, 0, 0, 0, 1);
            UpdateStats();
        }
    }
}
