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

namespace StudentDuty
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

        private void pickDuty_Click(object sender, RoutedEventArgs e)
        {
            PickDuty pickDuty = new PickDuty();
            pickDuty.Show();
        }

        private void showListBtn_Click(object sender, RoutedEventArgs e)
        {
            ShowList showList = new ShowList();
            showList.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }
    }
}
