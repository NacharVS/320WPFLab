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
using Microsoft.Win32;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для RedactPerson.xaml
    /// </summary>
    public partial class RedactPerson : Page
    {
        BaseClass selectedPerson;
        int valuePointtoChange = 200;
        int MaxPointToChange = 200;
        int valuePoint = 1;
        public RedactPerson(BaseClass person)
        {
            InitializeComponent();

            selectedPerson = person;
            refreshTextBox();
            
            imagePerson.Source = new BitmapImage(new Uri(selectedPerson.imgSource));


        }
        private void refreshTextBox()
        {
            StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
            DexterityTextBox.Text = Convert.ToString(selectedPerson.Dexterity);
            IntelliganceTextBox.Text = Convert.ToString(selectedPerson.Intelligance);
            ConstitutionTextBox.Text = Convert.ToString(selectedPerson.Constitution);

            PAttackTextBox.Text = Convert.ToString(selectedPerson.PAttack);
            PDefenseTextBox.Text = Convert.ToString(selectedPerson.PDefense);
            PCriticalChanseTextBox.Text = Convert.ToString(selectedPerson.PCriticalChanse);
            PCriticalDamageTextBox.Text = Convert.ToString(selectedPerson.PCriticalDamage);

            MAttackTextBox.Text = Convert.ToString(selectedPerson.MAttack);
            MDefenseTextBox.Text = Convert.ToString(selectedPerson.MDefense);
            MCriticalChanseTextBox.Text = Convert.ToString(selectedPerson.MCriticalChanse);
            MCriticalDamageTextBox.Text = Convert.ToString(selectedPerson.MCriticalDamage);

            pointsTextBox.Text = Convert.ToString(valuePointtoChange);
        }

        private void StrenPlus_Click(object sender, RoutedEventArgs e)
        {
            if(valuePointtoChange > 0 && selectedPerson.Strenght < selectedPerson.MaxStrenght) {
                valuePointtoChange -= 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Strenght += valuePoint;
                StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
                selectedPerson.StrenghtChange();
                refreshTextBox();
            }
        }

        private void StrenMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange < MaxPointToChange && selectedPerson.Strenght > selectedPerson.MinStrenght)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Strenght -= valuePoint;
                StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
                selectedPerson.StrenghtChange();
                refreshTextBox();
            }
            
        }

        private void DexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange > 0 && selectedPerson.Dexterity < selectedPerson.MaxDexterity)
            {
                valuePointtoChange -= 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Dexterity += valuePoint;
                DexterityTextBox.Text = Convert.ToString(selectedPerson.Dexterity);
                selectedPerson.DexterityChange();
                refreshTextBox();
            }
            
        }

        private void DexMinus_Click(object sender, RoutedEventArgs e)
        {
            
            if (valuePointtoChange < MaxPointToChange && selectedPerson.Dexterity > selectedPerson.MinDexterity)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Dexterity -= valuePoint;
                DexterityTextBox.Text = Convert.ToString(selectedPerson.Dexterity);
                selectedPerson.DexterityChange();
                refreshTextBox();
            }
        }

        private void IntPlus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange > 0 && selectedPerson.Intelligance < selectedPerson.MaxIntelligance)
            {
                valuePointtoChange -= 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Intelligance += valuePoint;
                IntelliganceTextBox.Text = Convert.ToString(selectedPerson.Intelligance);
                selectedPerson.IntelliganceChange();
                refreshTextBox();
            }
            
        }

        private void IntMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange < MaxPointToChange && selectedPerson.Intelligance > selectedPerson.MinIntelligance)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Intelligance -= valuePoint;
                IntelliganceTextBox.Text = Convert.ToString(selectedPerson.Intelligance);
                selectedPerson.IntelliganceChange();
                refreshTextBox();
            }
            
        }

        private void ConPlus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange > 0 && selectedPerson.Constitution < selectedPerson.MaxConstitution)
            {
                valuePointtoChange -= 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Constitution += valuePoint;
                ConstitutionTextBox.Text = Convert.ToString(selectedPerson.Constitution);
                selectedPerson.ConstitutionChange();
                refreshTextBox();
            }
            
        }

        private void ConMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange < MaxPointToChange && selectedPerson.Constitution > selectedPerson.MinConstitution)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Constitution -= valuePoint;
                ConstitutionTextBox.Text = Convert.ToString(selectedPerson.Constitution);
                selectedPerson.ConstitutionChange();
                refreshTextBox();
            }
            
        }

        private void backToChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChooseAvatarPage());
        }
    }
}
