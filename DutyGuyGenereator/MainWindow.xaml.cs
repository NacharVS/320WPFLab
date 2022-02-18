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

            PickStudents();
        }

        private void AddGuy_Click(object sender, RoutedEventArgs e)
        {
            Add_Guy_Window window = new Add_Guy_Window();
            window.Show();
            Close();
        }
        public  void PickStudents()
        {
            Student[] result = new Student[2];
            Random random = new Random();
            var student = new MongoClient("mongodb://localhost");
            var database = student.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            var neededStudent = collection.Find(x => true).ToList();
            var first = neededStudent[random.Next(0, neededStudent.Count())];
            result[0] = first;
            var second = neededStudent[random.Next(0, neededStudent.Count())];

            while (true)
            {
                if (first != second)
                {
                    result[1] = second;
                    break;
                }
                second = neededStudent[random.Next(0, neededStudent.Count())];
            }
            FirstSurname.Text = result[0].Name + " " + result[0].Surname;
            SecondSurname.Text = result[0].Name + " " + result[0].Surname;
        }

    }
}
