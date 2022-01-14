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
using CoreLibrary;

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

        private void btn_create_Click(object sender, RoutedEventArgs e)
        {
            ChangeStats changeStats = new ChangeStats();
            changeStats.Show();
            Close();
        }

        private void cb_char_type_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string type = ((sender as ListView).SelectedItem as TextBlock).Text;
            if (type == "Warrior") CoreLibrary.Globals.character = new Warrior();
            else if (type == "Mage") CoreLibrary.Globals.character = new Mage();
            else if (type == "Archer") CoreLibrary.Globals.character = new Archer();
        }
    }
}
