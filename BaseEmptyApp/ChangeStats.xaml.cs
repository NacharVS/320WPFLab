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
            lb_str.Content = $"";
            lb_dex.Content = $"";
            lb_int.Content = $"";
            lb_con.Content = $"";
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
    }
}
