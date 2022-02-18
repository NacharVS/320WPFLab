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

namespace Mongo
{
    /// <summary>
    /// Interaction logic for ShowList.xaml
    /// </summary>
    public partial class ShowList : Window
    {
        public ShowList()
        {
            InitializeComponent();
            LoadData();
        }

        private async void LoadData()
        {
            string connectionString = "mongodb://localhost";
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
    }

    public class Student
    {
        [BsonId]
        [BsonIgnoreIfDefault]
        public ObjectId _id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }

        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
    }
        

}
