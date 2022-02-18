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
using DutyGuyGenereator.DataBase;
using MongoDB.Driver;

namespace DutyGuyGenereator
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


        private void Generate_Click(object sender, RoutedEventArgs e)
        {
            
            FirstSurname.Text = DataAccess.GetDutyGuys()[0].Surname;
            SecondSurname.Text = DataAccess.GetDutyGuys()[1].Surname;

        }

        private void AddGuy_Click(object sender, RoutedEventArgs e)
        {
            Add_Guy_Window window = new Add_Guy_Window();
            window.Show();
            Close();
        }
       

    }
}
