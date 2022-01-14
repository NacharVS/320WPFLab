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
using CharacterCore;



namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string character = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Archer_Click(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor(new Archer());
            editor.Show();
            this.Close();
            character = "Archer";
        }

        private void Warrior_Click(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor(new Warrior());
            editor.Show();
            this.Close();
            character = "Warrior";
        }

        private void Mage_Click(object sender, RoutedEventArgs e)
        {
            Editor editor = new Editor(new Mage());
            editor.Show();
            this.Close();
            character = "Mage";
        }
    }
}
