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
    public partial class pageMain : Page
    {
        public Character Character { get; set; }

        public pageMain(Character character)
        {
            InitializeComponent();
            Character = character;
            imageCharacter.Source = new BitmapImage(new Uri(Character.imgCharacter));
            this.DataContext = this;
            GetCharacteristics();
        }

        private void revers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        public void GetCharacteristics()
        {
            intel.Text = Character.Intelligence.ToString();
            str.Text = Character.Strength.ToString();
            con.Text = Character.Constitution.ToString();
            dex.Text = Character.Dexterity.ToString();

            mAttack_value.Content = Character.Magical.Attack;
            mDefense_value.Content = Character.Magical.Defense;
            mCriticalChanse_value.Content = Character.Magical.CriticalChanse;
            mCriticalDamage_value.Content = Character.Magical.CriticalDamage;

            pAttack_value.Content = Character.Physical.Attack;
            pDefense_value.Content = Character.Physical.Defense;
            pCriticalChanse_value.Content = Character.Physical.CriticalChanse;
            pCriticalDamage_value.Content = Character.Physical.CriticalDamage;

            health_value.Content = Character.Health;
            mana_value.Content = Character.Mana;

            extraPoint.Text = Character.ExtraPoint.ToString();
        }

        private bool IsTrue()
        {
            if (Character.ExtraPoint == 0)
            {
                MessageBox.Show("Extra points are over");               
                return false;
            }
            else
            {
                Character.ExtraPoint--;
                return true;
            }
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity < Character.MaxDexterity)
            {
                if (IsTrue())
                    Character.Dexterity++;     
                    GetCharacteristics();
            }           
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Dexterity > Character.MinDexterity)
            {
                Character.Dexterity--;
                Character.ExtraPoint++;
                GetCharacteristics();
            }         
        }

        private void strMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Strength > Character.MinStrength)
            {
                Character.Strength--;
                Character.ExtraPoint++;
                GetCharacteristics();
            }
        }

        private void strPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Strength < Character.MaxStrength)
            {
                if (IsTrue())
                    Character.Strength++;
                    GetCharacteristics();
            }
        }

        private void intelMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence > Character.MinIntelligence)
            {
                Character.Intelligence--;
                Character.ExtraPoint++;
                GetCharacteristics();
            }
        }

        private void intelPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Intelligence < Character.MaxIntelligence)
            {
                if (IsTrue())
                    Character.Intelligence++;
                    GetCharacteristics();
            }
        }

        private void conMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Constitution > Character.MinConstitution)
            {
                Character.Constitution--;
                Character.ExtraPoint++;
                GetCharacteristics();
            }
        }

        private void conPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Character.Constitution < Character.MaxConstitution)
            {
                if (IsTrue())
                    Character.Constitution++;
                    GetCharacteristics();
            }
        }

        private void extrPlus_Click(object sender, RoutedEventArgs e)
        {
            Character.ExtraPoint++;
            GetCharacteristics();
        }
    }
}
