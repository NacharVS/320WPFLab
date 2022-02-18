using MongoDB.Bson;
using MongoDB.Driver;
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

namespace DutySelectProject
{
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        public Entity CreateDuty()
        {
            Entity entity1 = new Entity(tbName.Text, tbSurname.Text);
            return entity1;
        }

        public async void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Students");
            var collection = database.GetCollection<Entity>("TestEntities");
            await collection.InsertOneAsync(CreateDuty());
            NavigationService.Navigate(new MainPage());
        }

        private void btnList_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MainPage());
        }
    }

    public class Entity
    {
        public Entity(string name, string surname)
        {
            Name = name;
            Surname = surname;
        }
        public static async Task GetAllFromMongo()
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Students");
            var collection = database.GetCollection<Entity>("TestEntities");
            var list = await collection.Find(x => true).ToListAsync();
        }
        public ObjectId _id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
