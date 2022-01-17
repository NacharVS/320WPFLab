using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonWarrior_Click(object sender, RoutedEventArgs e)
        {
            Char har = new Char(new Warrior());
            har.Show();
            this.Close();
        }

        private void ButtonMage_Click(object sender, RoutedEventArgs e)
        {
            Char har = new Char(new Mage());
            har.Show();
            this.Close();
        }

        private void ButtonArcher_Click(object sender, RoutedEventArgs e)
        {
            Char har = new Char(new Archer());
            har.Show();
            this.Close();
        }
    }
}
