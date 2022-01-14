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
        string type { get; set; }
        public pageMain(Character character)
        {
            InitializeComponent();
            Character = character;
            //health.Text = Character.Health.ToString();
            //mana.Text = Character.Mana.ToString();
            this.DataContext = this;
        }

        private void revers_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
        public void GetCharacteristics()
        {
            if (position_txt.Text == "Magical")
            {
                MagicalStats mag = new MagicalStats(Convert.ToInt32(str.Text), Convert.ToInt32(dex.Text), Convert.ToInt32(intel.Text), Convert.ToInt32(con.Text));
                attack_value.Content = mag.Attack;
                defense_value.Content = mag.Defense;
                criticalChanse_value.Content = mag.CriticalChanse;
                criticalDamage_value.Content = mag.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
                //MessageBox.Show($"{mag.Attack},{mag.Defense},{mag.CriticalChanse},{mag.CriticalDamage}");
            }
            else
            {
                PhysicalStats phy = new PhysicalStats(Convert.ToInt32(str.Text), Convert.ToInt32(dex.Text), Convert.ToInt32(intel.Text), Convert.ToInt32(con.Text));
                attack_value.Content = phy.Attack;
                defense_value.Content = phy.Defense;
                criticalChanse_value.Content = phy.CriticalChanse;
                criticalDamage_value.Content = phy.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
                //MessageBox.Show($"{phy.Attack},{phy.Defense},{phy.CriticalChanse},{phy.CriticalDamage}");
            }
        }

        private void ok_Click(object sender, RoutedEventArgs e)
        {
            if (position_txt.Text == "Magical")
            {
                MagicalStats mag = new MagicalStats(Convert.ToInt32(str.Text), Convert.ToInt32(dex.Text), Convert.ToInt32(intel.Text), Convert.ToInt32(con.Text));
                attack_value.Content = mag.Attack;
                defense_value.Content = mag.Defense;
                criticalChanse_value.Content = mag.CriticalChanse;
                criticalDamage_value.Content = mag.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
                //MessageBox.Show($"{mag.Attack},{mag.Defense},{mag.CriticalChanse},{mag.CriticalDamage}");
            }
            else
            {
                PhysicalStats phy = new PhysicalStats(Convert.ToInt32(str.Text), Convert.ToInt32(dex.Text), Convert.ToInt32(intel.Text), Convert.ToInt32(con.Text));
                attack_value.Content = phy.Attack;
                defense_value.Content = phy.Defense;
                criticalChanse_value.Content = phy.CriticalChanse;
                criticalDamage_value.Content = phy.CriticalDamage;
                health_value.Content = Character.Health;
                mana_value.Content = Character.Mana;
                //MessageBox.Show($"{phy.Attack},{phy.Defense},{phy.CriticalChanse},{phy.CriticalDamage}");
            }
        }

        private void position_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            type = (sender as ComboBox).SelectedItem.ToString();
        }

        private void dexPlus_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint.Text == "0")
            {
                MessageBox.Show("!!!");
                dex.Text = Character.MinDexterity.ToString();
            }
            //if (dex.Text == Character.MaxDexterity.ToString())
            //{
            //    GetCharacteristics();
            //    dex.Text = Character.MinDexterity.ToString();
            //}
                
            dex.Text = Character.Dexterity++.ToString();
            extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();
            if (extraPoint.Text == "0")
            {
                MessageBox.Show("!!!");
                dex.Text = Character.MinDexterity.ToString();
            }
            GetCharacteristics();
        }

        private void dexMinus_Click(object sender, RoutedEventArgs e)
        {
            if (extraPoint.Text == "0")
            {
                MessageBox.Show("!!!");
                dex.Text = Character.MinDexterity.ToString();
            }
            else
            {
                dex.Text = Character.Dexterity--.ToString();
                extraPoint.Text = (Convert.ToInt32(extraPoint.Text) - 1).ToString();

                GetCharacteristics();
            }
          
        }
    }
}
