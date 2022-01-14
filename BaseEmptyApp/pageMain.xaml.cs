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
        public string type { get; set; }
        public pageMain(Character character)
        {
            InitializeComponent();
            Character = character;
            type_txt.Text = "Magical";
            this.DataContext = this;
            GetCharacteristics();
        }

        private void revers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        public void GetCharacteristics()
        {
            if (type_txt.Text == "Magical")
            {
                attack_value.Content = Character.Magical.Attack;
                defense_value.Content = Character.Magical.Defense;
                criticalChanse_value.Content = Character.Magical.CriticalChanse;
                criticalDamage_value.Content = Character.Magical.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
            }
            else
            {
                attack_value.Content = Character.Physical.Attack;
                defense_value.Content = Character.Physical.Defense;
                criticalChanse_value.Content = Character.Physical.CriticalChanse;
                criticalDamage_value.Content = Character.Physical.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
            }
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(dex.Text) < Character.MaxDexterity)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Dexterity++;
                    dex.Text = Character.Dexterity.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }           
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(dex.Text) > Character.MinDexterity)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Dexterity--;
                    dex.Text = Character.Dexterity.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }         
        }

        private void strMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(str.Text) > Character.MinStrength)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Strength--;
                    str.Text = Character.Strength.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void strPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(str.Text) < Character.MaxStrength)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Strength++;
                    str.Text = Character.Strength.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void intelMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(intel.Text) > Character.MinIntelligence)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Intelligence--;
                    intel.Text = Character.Intelligence.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void intelPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(intel.Text) < Character.MaxIntelligence)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Intelligence++;
                    intel.Text = Character.Intelligence.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void conMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(con.Text) > Character.MinConstitution)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Constitution--;
                    con.Text = Character.Constitution.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void conPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Convert.ToInt32(con.Text) < Character.MaxConstitution)
            {
                if (extraPoint.Text == "0")
                {
                    GetCharacteristics();
                }
                else
                {
                    Character.Constitution++;
                    con.Text = Character.Constitution.ToString();
                    extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
                    GetCharacteristics();
                }
            }
        }

        private void type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            type = (sender as ComboBox).SelectedItem.ToString();
          
        }
    }
}
