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
    /// Interaction logic for PageChar.xaml
    /// </summary>
    public partial class PageChar : Page
    {
        characteristics characteristics { get; set; }
        public PageChar(characteristics newcharacteristics)
        {
            InitializeComponent();
            characteristics = newcharacteristics;
            UpdateStats();
        }

        private void EditCharecteristic(int s, int d, int i, int c, int p)
        {
            try
            {
                characteristics.Strength += s;
                characteristics.Dexterity += d;
                characteristics.Intelligence += i;
                characteristics.Constitution += c;
                characteristics.Points += p;
                UpdateStats();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void UpdateStats()
        {
            tbPoints.Text = characteristics.Points.ToString();

            tbStrength.Text = characteristics.Strength.ToString();
            tbDexterity.Text = characteristics.Dexterity.ToString();
            tbIntelligence.Text = characteristics.Intelligence.ToString();
            tbConstitution.Text = characteristics.Constitution.ToString();

            tbHealth.Text = characteristics.Health.ToString();
            tbMana.Text = characteristics.Mana.ToString();

            tbPAttack.Text = characteristics.Physic.Attack.ToString();
            tbPDefense.Text = characteristics.Physic.Defense.ToString();
            tbMAttack.Text = characteristics.Magic.Attack.ToString();
            tbMDefense.Text = characteristics.Magic.Defense.ToString();
            tbPCriticalChance.Text = characteristics.Physic.CriticalChance.ToString();
            tbMCriticalChance.Text = characteristics.Magic.CriticalChance.ToString();
            tbPCriticalDamage.Text = characteristics.Physic.CriticalDamage.ToString();
            tbMCriticalDamage.Text = characteristics.Magic.CriticalDamage.ToString();
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
