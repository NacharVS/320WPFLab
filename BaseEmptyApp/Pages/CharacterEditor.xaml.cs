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
using BaseEmptyApp.Core.Classes;
using Microsoft.Win32;

namespace BaseEmptyApp.Pages
{
    /// <summary>
    /// Логика взаимодействия для CharacterEditor.xaml
    /// </summary>
    public partial class CharacterEditor : Page
    {
        BaseClass choosedChacter;
        int defaultPoint = 100;
        int amountPoint = 5;
        public CharacterEditor(BaseClass character)
        {
            InitializeComponent();

            choosedChacter = character;
            UpdateCharasteristics();

            imagePerson.Source = new BitmapImage(new Uri(choosedChacter.imgPath));


        }
        private void UpdateCharasteristics()
        {
            HealthTextBox.Text = Convert.ToString(choosedChacter.Health);
            ManaTextBox.Text = Convert.ToString(choosedChacter.Mana);
            StrengthTextBox.Text = Convert.ToString(choosedChacter.Strenght);
            DexterityTextBox.Text = Convert.ToString(choosedChacter.Dexterity);
            IntelliganceTextBox.Text = Convert.ToString(choosedChacter.Intelligance);
            ConstitutionTextBox.Text = Convert.ToString(choosedChacter.Constitution);

            PAttackTextBox.Text = Convert.ToString(choosedChacter.PhysAttack);
            PDefenseTextBox.Text = Convert.ToString(choosedChacter.PhysDefense);
            PCriticalChanseTextBox.Text = Convert.ToString(choosedChacter.PhysCriticalChanse);
            PCriticalDamageTextBox.Text = Convert.ToString(choosedChacter.PhysCriticalDamage);

            MAttackTextBox.Text = Convert.ToString(choosedChacter.MagicAttack);
            MDefenseTextBox.Text = Convert.ToString(choosedChacter.MagicDefense);
            MCriticalChanseTextBox.Text = Convert.ToString(choosedChacter.MagicCriticalChanse);
            MCriticalDamageTextBox.Text = Convert.ToString(choosedChacter.MagicCriticalDamage);

            pointsTextBox.Text = Convert.ToString(defaultPoint);
        }

        private void StrenPlus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint > 0 && choosedChacter.Strenght < choosedChacter.MaxStrenght)
            {
                defaultPoint -= 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Strenght += amountPoint;
                StrengthTextBox.Text = Convert.ToString(choosedChacter.Strenght);
                choosedChacter.StrenghtChange();
                UpdateCharasteristics();
            }
        }

        private void StrenMinus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint >= 0 && choosedChacter.Strenght > choosedChacter.MinStrenght)
            {
                defaultPoint += 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Strenght -= amountPoint;
                StrengthTextBox.Text = Convert.ToString(choosedChacter.Strenght);
                choosedChacter.StrenghtChange();
                UpdateCharasteristics();
            }

        }

        private void DexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint > 0 && choosedChacter.Dexterity < choosedChacter.MaxDexterity)
            {
                defaultPoint -= 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Dexterity += amountPoint;
                DexterityTextBox.Text = Convert.ToString(choosedChacter.Dexterity);
                choosedChacter.DexterityChange();
                UpdateCharasteristics();
            }

        }

        private void DexMinus_Click(object sender, RoutedEventArgs e)
        {

            if (defaultPoint >= 0 && choosedChacter.Dexterity > choosedChacter.MinDexterity)
            {
                defaultPoint += 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Dexterity -= amountPoint;
                DexterityTextBox.Text = Convert.ToString(choosedChacter.Dexterity);
                choosedChacter.DexterityChange();
                UpdateCharasteristics();
            }
        }

        private void IntPlus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint > 0 && choosedChacter.Intelligance < choosedChacter.MaxIntelligance)
            {
                defaultPoint -= 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Intelligance += amountPoint;
                IntelliganceTextBox.Text = Convert.ToString(choosedChacter.Intelligance);
                choosedChacter.IntelliganceChange();
                UpdateCharasteristics();
            }

        }

        private void IntMinus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint >= 0 && choosedChacter.Intelligance > choosedChacter.MinIntelligance)
            {
                defaultPoint += 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Intelligance -= amountPoint;
                IntelliganceTextBox.Text = Convert.ToString(choosedChacter.Intelligance);
                choosedChacter.IntelliganceChange();
                UpdateCharasteristics();
            }

        }

        private void ConPlus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint > 0 && choosedChacter.Constitution < choosedChacter.MaxConstitution)
            {
                defaultPoint -= 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Constitution += amountPoint;
                ConstitutionTextBox.Text = Convert.ToString(choosedChacter.Constitution);
                choosedChacter.ConstitutionChange();
                UpdateCharasteristics();
            }

        }

        private void ConMinus_Click(object sender, RoutedEventArgs e)
        {
            if (defaultPoint >= 0 && choosedChacter.Constitution > choosedChacter.MinConstitution)
            {
                defaultPoint += 1;
                pointsTextBox.Text = Convert.ToString(defaultPoint);
                choosedChacter.Constitution -= amountPoint;
                ConstitutionTextBox.Text = Convert.ToString(choosedChacter.Constitution);
                choosedChacter.ConstitutionChange();
                UpdateCharasteristics();
            }

        }


        private void backToChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChooseCharacter());
        }

        private void btnPlusPointClick(object sender, RoutedEventArgs e)
        {
            defaultPoint += 5;
            pointsTextBox.Text = Convert.ToString(defaultPoint);
        }
    }
}
