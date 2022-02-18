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
    }
}
