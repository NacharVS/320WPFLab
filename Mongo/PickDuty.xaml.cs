using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
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
    /// Interaction logic for PickDuty.xaml
    /// </summary>
    public partial class PickDuty : Window
    {
        public PickDuty()
        {
            InitializeComponent();
            PickStudents();
            
        }

        public void PickStudents()
        {
            Student[] result = new Student[2];
            Random random = new Random();
            var student = new MongoClient("mongodb://localhost");
            var database = student.GetDatabase("test");
            var collection = database.GetCollection<Student>("users");
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

            firstStudent.Text = result[0].Name + " " + result[0].Surname;
            secondStudent.Text = result[1].Name + " " + result[1].Surname;
        }

        private void repick_Btn_Click(object sender, RoutedEventArgs e)
        {
            PickStudents();
        }
    }
}

