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
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using System.ComponentModel.DataAnnotations;

namespace Mongo
{
    /// <summary>
    /// Interaction logic for ShowList.xaml
    /// </summary>
    public partial class ShowList : Window
    {
        public static Student selectedStudent;
        public static string connectionString = "mongodb://localhost";

        public ShowList()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<Student>("users");
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

            listviewUsers.ItemsSource = students;

            //var document = await collection.Find(new BsonDocument()).ToListAsync();
            //
            //foreach(var doc in document)
            //{
            //    listviewUsers.SelectedItem = doc;
            //}
            //listviewUsers.ItemsSource = document;
            
        }

        private void listviewUsers_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedStudent = listviewUsers.SelectedItem as Student;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txt_name.Text != "" && txt_surname.Text != "")
            {
                UpdateMongo(txt_name.Text, txt_surname.Text);
                MessageBox.Show("Данные изменены");
            }      
        }
        
        private static async Task UpdateMongo(string name, string surname)
        {
            var client = new MongoClient(connectionString);
            var database = client.GetDatabase("test");
            var collection = database.GetCollection<Student>("users");
            var definition1 = Builders<Student>.Update.Set(x => x.Name, name);
            var definition2 = Builders<Student>.Update.Set(x => x.Surname, surname);
            await collection.UpdateOneAsync(x => x.Name == selectedStudent.Name, definition1);
            await collection.UpdateOneAsync(x => x.Surname == selectedStudent.Surname, definition2);
        }
    }

    public class Student
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string Name { get; set; }
        [Required]
        [StringLength(25, MinimumLength = 2)]
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
        

}
