using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Characters;
using Core;
using static Core.Character;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public Character hero;
        public int points;

        private void ComboCharacter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

            string item = selectedItem.Content.ToString();

            switch (item)
            {
                case "Mage":
                    Mage mage = new Mage();

                    Fill(mage);

                    hero = mage;
                    points = hero.ExtraPoint;
                    break;
                case "Warrior":
                    Warrior warrior = new Warrior();

                    Fill(warrior);

                    hero = warrior;
                    points = hero.ExtraPoint;
                    break;
                case "Archer":
                    Archer archer = new Archer();

                    Fill(archer);

                    hero = archer;
                    points = hero.ExtraPoint;
                    break;
                default:
                    break;
            }
            points = hero.ExtraPoint;
            text_point.Content = points;
        }

        public void Refresh()
        {
            text_p_atck.Content = hero.Сharacts.P_Attack;
            text_m_atck.Content = hero.Сharacts.M_Attack;

            text_p_def.Content = hero.Сharacts.P_defense;
            text_m_def.Content = hero.Сharacts.M_defense;

            text_p_CritlCh.Content = hero.Сharacts.P_CriticalChance;
            text_m_CritlCh.Content = hero.Сharacts.M_CriticalChance;

            text_p_critDmg.Content = hero.Сharacts.P_criticalDamage;
            text_m_critDmg.Content = hero.Сharacts.M_criticalDamage;
        }

        public void Fill(Character character)
        {
            text_strng.Content = character.Strength;
            text_dex.Content = character.Dexterity;
            text_intel.Content = character.Intelligence;
            text_const.Content = character.Constitution;
        }

        private void btn_minus_str_Click(object sender, RoutedEventArgs e)
        {
            hero.Strength--;
            hero.ExtraPoint++;

            text_strng.Content = hero.Strength;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_plus_str_Click(object sender, RoutedEventArgs e)
        {
            hero.Strength++;
            hero.ExtraPoint--;

            text_strng.Content = hero.Strength;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_minus_dex_Click(object sender, RoutedEventArgs e)
        {
            hero.Dexterity--;
            hero.ExtraPoint++;

            text_dex.Content = hero.Dexterity;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_plus_dex_Click(object sender, RoutedEventArgs e)
        {
            hero.Dexterity++;
            hero.ExtraPoint--;

            text_dex.Content = hero.Dexterity;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_minus_intel_Click(object sender, RoutedEventArgs e)
        {
            hero.Intelligence--;
            hero.ExtraPoint++;

            text_intel.Content = hero.Intelligence;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_plus_intel_Click(object sender, RoutedEventArgs e)
        {
            hero.Intelligence++;
            hero.ExtraPoint--;

            text_intel.Content = hero.Intelligence;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_minus_cons_Click(object sender, RoutedEventArgs e)
        {
            hero.Constitution--;
            hero.ExtraPoint++;

            text_const.Content = hero.Constitution;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }

        private void btn_plus_cons_Click(object sender, RoutedEventArgs e)
        {
            hero.Constitution++;
            hero.ExtraPoint--;

            text_const.Content = hero.Constitution;
            text_point.Content = hero.ExtraPoint;

            Refresh();
        }
    }
}
