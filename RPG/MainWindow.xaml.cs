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

namespace RPG
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            string character_name = "";
            if (combobox1.SelectedItem != null) character_name = combobox1.Text;

            if (character_name == "Warrior")
            {
                Warrior_window warrior_window = new Warrior_window();
                warrior_window.Show();
            }

            else if (character_name == "Mage")
            {
                Mage_window mage_Window = new Mage_window();
                mage_Window.Show();
            }

            else if (character_name == "Archer")
            {
                Archer_window archer_Window = new Archer_window();
                archer_Window.Show();
            }

            else
            {

            }

        }
    }
}
