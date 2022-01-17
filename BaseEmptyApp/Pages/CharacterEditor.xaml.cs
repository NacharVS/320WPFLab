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
        BaseClass selectedPerson;
        int valuePointtoChange = 100;
        //int MaxPointToChange = 200;
        int valuePoint = 1;
        public CharacterEditor(BaseClass person)
        {
            InitializeComponent();

            selectedPerson = person;
            UpdateCharasteristics();

            imagePerson.Source = new BitmapImage(new Uri(selectedPerson.imgPath));


        }
        private void UpdateCharasteristics()
        {
            HealthTextBox.Text = Convert.ToString(selectedPerson.Health);
            ManaTextBox.Text = Convert.ToString(selectedPerson.Mana);
            StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
            DexterityTextBox.Text = Convert.ToString(selectedPerson.Dexterity);
            IntelliganceTextBox.Text = Convert.ToString(selectedPerson.Intelligance);
            ConstitutionTextBox.Text = Convert.ToString(selectedPerson.Constitution);

            PAttackTextBox.Text = Convert.ToString(selectedPerson.PhysAttack);
            PDefenseTextBox.Text = Convert.ToString(selectedPerson.PhysDefense);
            PCriticalChanseTextBox.Text = Convert.ToString(selectedPerson.PhysCriticalChanse);
            PCriticalDamageTextBox.Text = Convert.ToString(selectedPerson.PhysCriticalDamage);

            MAttackTextBox.Text = Convert.ToString(selectedPerson.MagicAttack);
            MDefenseTextBox.Text = Convert.ToString(selectedPerson.MagicDefense);
            MCriticalChanseTextBox.Text = Convert.ToString(selectedPerson.MagicCriticalChanse);
            MCriticalDamageTextBox.Text = Convert.ToString(selectedPerson.MagicCriticalDamage);

            pointsTextBox.Text = Convert.ToString(valuePointtoChange);
        }

        private void StrenPlus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange > 0 && selectedPerson.Strenght < selectedPerson.MaxStrenght)
            {
                valuePointtoChange -= 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Strenght += valuePoint;
                StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
                selectedPerson.StrenghtChange();
                UpdateCharasteristics();
            }
        }

        private void StrenMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange >= 0 && selectedPerson.Strenght > selectedPerson.MinStrenght)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Strenght -= valuePoint;
                StrengthTextBox.Text = Convert.ToString(selectedPerson.Strenght);
                selectedPerson.StrenghtChange();
                UpdateCharasteristics();
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
                UpdateCharasteristics();
            }

        }

        private void DexMinus_Click(object sender, RoutedEventArgs e)
        {

            if (valuePointtoChange >= 0 && selectedPerson.Dexterity > selectedPerson.MinDexterity)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Dexterity -= valuePoint;
                DexterityTextBox.Text = Convert.ToString(selectedPerson.Dexterity);
                selectedPerson.DexterityChange();
                UpdateCharasteristics();
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
                UpdateCharasteristics();
            }

        }

        private void IntMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange >= 0 && selectedPerson.Intelligance > selectedPerson.MinIntelligance)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Intelligance -= valuePoint;
                IntelliganceTextBox.Text = Convert.ToString(selectedPerson.Intelligance);
                selectedPerson.IntelliganceChange();
                UpdateCharasteristics();
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
                UpdateCharasteristics();
            }

        }

        private void ConMinus_Click(object sender, RoutedEventArgs e)
        {
            if (valuePointtoChange >= 0 && selectedPerson.Constitution > selectedPerson.MinConstitution)
            {
                valuePointtoChange += 1;
                pointsTextBox.Text = Convert.ToString(valuePointtoChange);
                selectedPerson.Constitution -= valuePoint;
                ConstitutionTextBox.Text = Convert.ToString(selectedPerson.Constitution);
                selectedPerson.ConstitutionChange();
                UpdateCharasteristics();
            }

        }


        private void backToChooseBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ChooseCharacter());
        }

        private void btnPlusPointClick(object sender, RoutedEventArgs e)
        {
            valuePointtoChange += 5;
            pointsTextBox.Text = Convert.ToString(valuePointtoChange);
        }
    }
}
