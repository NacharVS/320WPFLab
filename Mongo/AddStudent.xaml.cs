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
using System.Threading;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;
using System.ComponentModel.DataAnnotations;

namespace Mongo
{
    /// <summary>
    /// Interaction logic for AddStudent.xaml
    /// </summary>
    public partial class AddStudent : Window
    {
        public AddStudent()
        {
            InitializeComponent();
            if (name_txt.Text == "" || surname_txt.Text == "")
                addStudentBtn.IsEnabled = false;
        }

        private void addStudentBtn_Click(object sender, RoutedEventArgs e)
        {
            SaveDocs(name_txt.Text, surname_txt.Text);
        }

        private static async Task SaveDocs(string name, string surname)
        {
            string connectionString = "mongodb://localhost";
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<BsonDocument>("users");
            BsonDocument person1 = new BsonDocument
            {
                {"Name", name},
                {"Surname", surname},
            };
            await collection.InsertOneAsync(person1);
        }

        private void name_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string name = name_txt.Text;
            Student student = new Student(name, "Прикол");
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(student);
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                foreach (var error in results)
                {
                    name_annotation.Text = error.ErrorMessage;
                    addStudentBtn.IsEnabled = false;
                }
            }
            else
            {
                name_annotation.Text = "";
                addStudentBtn.IsEnabled = true;
            }
        }

        private void surname_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            string surname = surname_txt.Text;
            Student student = new Student("Прикол", surname);
            var results = new List<System.ComponentModel.DataAnnotations.ValidationResult>();
            var context = new ValidationContext(student);
            if (!Validator.TryValidateObject(student, context, results, true))
            {
                foreach (var error in results)
                {
                    surname_annotation.Text = error.ErrorMessage;
                    addStudentBtn.IsEnabled = false;
                }
            }
            else
            {
                surname_annotation.Text = "";
                addStudentBtn.IsEnabled = true;
            }
        }
    }
}
