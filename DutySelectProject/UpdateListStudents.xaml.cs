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
    public partial class UpdateListStudents : Page
    {
        public Entity Ent { get; set; }
        public UpdateListStudents(Entity ent)
        {
            InitializeComponent();
            Ent = ent;
            this.DataContext = this;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private async void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Students");
            var collection = database.GetCollection<Entity>("TestEntities");
            var definition = Builders<Entity>.Update.Set(x => x.Name, tbName.Text);
            var definition2 = Builders<Entity>.Update.Set(x => x.Surname, tbSurname.Text);
            await collection.UpdateOneAsync(x => x._id == Ent._id, definition);
            await collection.UpdateOneAsync(x => x._id == Ent._id, definition2);
        }
    }
}
