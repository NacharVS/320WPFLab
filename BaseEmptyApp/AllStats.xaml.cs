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

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для AllStats.xaml
    /// </summary>
    public partial class AllStats : Window
    {
        public AllStats()
        {
            InitializeComponent();
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            ChangeStats changeStats = new ChangeStats();
            changeStats.Show();
            Close();
        }
    }
}
