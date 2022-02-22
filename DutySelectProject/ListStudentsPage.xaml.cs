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
    /// Логика взаимодействия для ListStudentsPage.xaml
    /// </summary>
    public partial class ListStudentsPage : Page
    {
        public ListStudentsPage()
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://localhost");
            var database = client.GetDatabase("320Students");
            var collection = database.GetCollection<Entity>("TestEntities");
            var list = collection.Find(x => true).ToList();
            listStudents.ItemsSource = list;
        }

        private void backBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void listStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var a = (sender as ListView).SelectedItem as Entity;
            NavigationService.Navigate(new UpdateListStudents(a));
        }
    }
}
