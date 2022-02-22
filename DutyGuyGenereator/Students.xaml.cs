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
using System.Windows.Shapes;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using DutyGuyGenereator.DataBase;

namespace DutyGuyGenereator
{
    /// <summary>
    /// Логика взаимодействия для Students.xaml
    /// </summary>
    public partial class Students : Window
    {
        public static string name; 
        public static string surname;
        public Students()
        {
            InitializeComponent();
            LoadData();
            //LVStudents.ItemsSource = DataAccess.ShowProductsInCategory();
        }

        private void LVStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var selectedStudent = LVStudents.SelectedItem as Student;
            Surname.Text = selectedStudent.Surname;
            Name.Text = selectedStudent.Name;
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = LVStudents.SelectedItem as Student;
            DataAccess.EditStudent(selectedStudent.Surname, selectedStudent.Name, Name.Text, Surname.Text);
            MessageBox.Show("Студент редактирован");
        }
        private async void LoadData()
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("DutyGuy");
            var collection = database.GetCollection<Student>("Guy");
            var filter = new BsonDocument();

            List<Student> students = new List<Student>();

            using (var cursor = await collection.FindAsync(filter))
            {
                while (await cursor.MoveNextAsync())
                {
                    var people = cursor.Current;
                    foreach (Student doc in people)
                    {
                        students.Add(new Student(doc.Name, doc.Surname));
                    }
                }
            }
            LVStudents.ItemsSource = students;
            
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            var selectedStudent = LVStudents.SelectedItem as Student;
            Student student = new Student(selectedStudent.Name, selectedStudent.Surname);
            DataAccess.ReplaceStudent(student);
            MessageBox.Show("Студент удалён");
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }

        
    }
}
