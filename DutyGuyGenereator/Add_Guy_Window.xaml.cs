using System;

using System.Windows;


using DutyGuyGenereator.DataBase;

namespace DutyGuyGenereator
{
    /// <summary>
    /// Логика взаимодействия для Add_Guy_Window.xaml
    /// </summary>
    public partial class Add_Guy_Window : Window
    {
        public Add_Guy_Window()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            Student student = new Student(Name.Text, Surname.Text);
            DataAccess.AddStudentToDatabase(student);
            MessageBox.Show($"Студент '{student.Name}' был добавлен");
            Name.Clear();
            Surname.Clear();


        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
