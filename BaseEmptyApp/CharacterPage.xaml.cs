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
using CharacterLibrary;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public Character Character { get; set; }
        public CharacterPage(Character character)
        {
            InitializeComponent();
            Character = character;

            TbLabel.Text = Character.ToString();
            TbHealth.Text = Character.Health.ToString();
            TbMana.Text = Character.Mana.ToString();

            TbPhAttack.Text = Character.Physic.Attack.ToString();
            TbPhDefense.Text = Character.Physic.Defense.ToString();
            TbPhCritChance.Text = Character.Physic.CriticalChance.ToString();
            TbPhCritDamage.Text = Character.Physic.CriticalDamage.ToString();

            TbMagAttack.Text = Character.Magic.Attack.ToString();
            TbMagDefense.Text = Character.Magic.Defense.ToString();
            TbMagCritChance.Text = Character.Magic.CriticalChance.ToString();
            TbMagCritDamage.Text = Character.Magic.CriticalDamage.ToString();

            this.DataContext = this;
        }
        private void UpdateStats()
        {
            try
            {

                Character.Strength = int.Parse(TbStrength.Text);
                Character.Dexterity = int.Parse(TbDexterity.Text);
                Character.Intelligence = int.Parse(TbIntelligence.Text);
                Character.Constitution = int.Parse(TbConstitution.Text);
                Character.Points = int.Parse(TbPoints.Text);
            }
            catch
            {
                MessageBox.Show("Wrong values");
            }
            NavigationService.Navigate(new CharacterPage(Character));
        }
        private void BtnStrengthMinus_Click(object sender, RoutedEventArgs e)
        {
            TbStrength.Text = (int.Parse(TbStrength.Text) - 1).ToString();
            if (int.Parse(TbStrength.Text) >= Character.minStrength)
                TbPoints.Text = (int.Parse(TbPoints.Text) + 1).ToString();
            UpdateStats();
        }

        private void BtnStrengthPlus_Click(object sender, RoutedEventArgs e)
        {
            TbStrength.Text = (int.Parse(TbStrength.Text) + 1).ToString();
            if (int.Parse(TbStrength.Text) <= Character.maxStrength)
                TbPoints.Text = (int.Parse(TbPoints.Text) - 1).ToString();
            UpdateStats();
        }

        private void BtnDexterityMinus_Click(object sender, RoutedEventArgs e)
        {
            TbDexterity.Text = (int.Parse(TbDexterity.Text) - 1).ToString();
            if (int.Parse(TbDexterity.Text) >= Character.minDexterity)
                TbPoints.Text = (int.Parse(TbPoints.Text) + 1).ToString();
            UpdateStats();
        }

        private void BtnDexterityPlus_Click(object sender, RoutedEventArgs e)
        {
            TbDexterity.Text = (int.Parse(TbDexterity.Text) + 1).ToString();
            if (int.Parse(TbDexterity.Text) <= Character.maxDexterity)
                TbPoints.Text = (int.Parse(TbPoints.Text) - 1).ToString();
            UpdateStats();
        }

        private void BtnIntelligenceMinus_Click(object sender, RoutedEventArgs e)
        {
            TbIntelligence.Text = (int.Parse(TbIntelligence.Text) - 1).ToString();
            if (int.Parse(TbIntelligence.Text) >= Character.minIntelligence)
                TbPoints.Text = (int.Parse(TbPoints.Text) + 1).ToString();
            UpdateStats();
        }

        private void BtnIntelligencePlus_Click(object sender, RoutedEventArgs e)
        {
            TbIntelligence.Text = (int.Parse(TbIntelligence.Text) + 1).ToString();
            if (int.Parse(TbIntelligence.Text) <= Character.maxIntelligence)
                TbPoints.Text = (int.Parse(TbPoints.Text) - 1).ToString();
            UpdateStats();
        }

        private void BtnConstitutionMinus_Click(object sender, RoutedEventArgs e)
        {
            TbConstitution.Text = (int.Parse(TbConstitution.Text) - 1).ToString();
            if (int.Parse(TbConstitution.Text) >= Character.minConstitution)
                TbPoints.Text = (int.Parse(TbPoints.Text) + 1).ToString();
            UpdateStats();
        }

        private void BtnConstitutionPlus_Click(object sender, RoutedEventArgs e)
        {
            TbConstitution.Text = (int.Parse(TbConstitution.Text) + 1).ToString();
            if (int.Parse(TbConstitution.Text) <= Character.maxConstitution)
                TbPoints.Text = (int.Parse(TbPoints.Text) - 1).ToString();
            UpdateStats();
        }
    }
}
