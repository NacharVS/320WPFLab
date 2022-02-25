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
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Students");
            var collection = database.GetCollection<Entity>("TestEntities");
            var list =  collection.Find(x => true).ToList();
            var rnd = new Random();
            int studentOne = rnd.Next(0, list.Count);
            student1.Text = $"{list[studentOne].Name} {list[studentOne].Surname}";           
            list.RemoveAt(studentOne);
            var rnd2 = new Random();
            int studentTwo = rnd2.Next(0, list.Count);
            student2.Text = $"{list[studentTwo].Name} {list[studentTwo].Surname}";
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
