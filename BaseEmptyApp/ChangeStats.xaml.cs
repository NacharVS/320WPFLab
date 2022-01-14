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
using System.Windows.Shapes;
using CoreLibrary;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для ChangeStats.xaml
    /// </summary>
    public partial class ChangeStats : Window
    {
        public ChangeStats()
        {
            InitializeComponent();
            lb_char.Content = $"Your class: {CoreLibrary.Globals.character.CharacterType}";
            lb_str.Content = $"Strength: {CoreLibrary.Globals.character.Strength}";
            lb_dex.Content = $"Dexterity: {CoreLibrary.Globals.character.Dexterity}";
            lb_int.Content = $"Intelligence: {CoreLibrary.Globals.character.Intelligence}";
            lb_con.Content = $"Constitution: {CoreLibrary.Globals.character.Constitution}";
            lb_extra_points.Content = $"Extra Points: {CoreLibrary.Globals.character.extraPoints}";

        }

        private void btn_str_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_str_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dex_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_dex_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_int_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_int_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_con_minus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_con_plus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            Close();
        }
    }
}
