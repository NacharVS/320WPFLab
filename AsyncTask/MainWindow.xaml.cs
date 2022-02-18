using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AsyncTask
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void AddNewElement_Click(object sender, RoutedEventArgs e)
        {
            int num = Convert.ToInt32(ValueItem.Text);
            //await Task.Run(() =>
            //{
            //for (int i = 1; i <= 7; i++)
            //{
            //    Dispatcher.Invoke((() =>
            //    {
            //        ItemsList.Items.Add(ValueItem.Text);
            //    }));
            //    Thread.Sleep(1000);
            //}

            //});
            Method(num);
            
        }
        public async void Method(int num)
        {
            
            for (int i = num; i >= 1; i--)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    ItemsList.Items.Add(i);
                }));
                await Task.Delay(500);
            }
        }

        private void SomeButton_Click(object sender, RoutedEventArgs e)
        {
            test.Text = "12";
        }
    }
}
