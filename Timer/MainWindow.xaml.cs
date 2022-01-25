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
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            TimeBlock.Text = "00:00:00";
            try
            {
                int time = Convert.ToInt32(TimeBox.Text);
                for (int i = 0; i <= time; i++)
                {
                    Thread.Sleep(1000);
                    if (i.ToString().Length == 1)
                        TimeBlock.Text = $"00:00:0{i.ToString()}";
                    else if (i.ToString().Length == 2)
                        TimeBlock.Text = $"00:00:{i.ToString()}";
                }
                MessageBox.Show("Таймер всё");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }


        }

        private async void StartAsync_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(TimeBox.Text);
                await Task.Run(() => TimeWait(time));
                MessageBox.Show("Таймер всё");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число");
            }

        }

        public void TimeWait(int time)
        {
            for (int i = 0; i <= time; i++)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    if (i.ToString().Length == 1)
                        TimeBlock.Text = $"00:00:0{i.ToString()}";
                    else if (i.ToString().Length == 2)
                        TimeBlock.Text = $"00:00:{i.ToString()}";
                }));
                Thread.Sleep(1000);
            }
        }
    }
}
