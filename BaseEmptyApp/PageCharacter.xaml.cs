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

        private void EditCharecteristic()
        {
            try
            {
                character.Strength = double.Parse(tbStrength.Text);
                character.Dexterity = double.Parse(tbDexterity.Text);
                character.Intelligence = double.Parse(tbIntelligence.Text);
                character.Constitution = double.Parse(tbConstitution.Text);
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
            tbStrength.Text = (int.Parse(tbStrength.Text) - 1).ToString();
            character.Points += 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnMinusDexterityClick(object sender, RoutedEventArgs e)
        {
            tbDexterity.Text = (int.Parse(tbDexterity.Text) - 1).ToString();
            character.Points += 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnMinusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            tbIntelligence.Text = (int.Parse(tbIntelligence.Text) - 1).ToString();
            character.Points += 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnMinusConstitutionClick(object sender, RoutedEventArgs e)
        {
            tbConstitution.Text = (int.Parse(tbConstitution.Text) - 1).ToString();
            character.Points += 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnPlusStrengthClick(object sender, RoutedEventArgs e)
        {
            tbStrength.Text = (int.Parse(tbStrength.Text) + 1).ToString();
            character.Points -= 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnPlusDexterityClick(object sender, RoutedEventArgs e)
        {
            tbDexterity.Text = (int.Parse(tbDexterity.Text) + 1).ToString();
            character.Points -= 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnPlusIntelligenceClick(object sender, RoutedEventArgs e)
        {
            tbIntelligence.Text = (int.Parse(tbIntelligence.Text) + 1).ToString();
            character.Points -= 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnPlusConstitutionClick(object sender, RoutedEventArgs e)
        {
            tbConstitution.Text = (int.Parse(tbConstitution.Text) + 1).ToString();
            character.Points -= 1;
            EditCharecteristic();
            UpdateStats();
        }

        private void btnPlusPointClick(object sender, RoutedEventArgs e)
        {
            tbPoints.Text = (int.Parse(tbPoints.Text) + 1).ToString();
            EditCharecteristic();
            UpdateStats();
        }
    }
}
