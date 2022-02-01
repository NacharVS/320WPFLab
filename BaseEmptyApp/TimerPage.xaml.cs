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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Threading.Tasks;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для TimerPage.xaml
    /// </summary>
    public partial class TimerPage : Page
    {
        public TimerPage()
        {
            InitializeComponent();
        }

        private async void AsyncStartTimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(Time.Text);
                await Task.Run(() => TimeWait(time));
                MessageBox.Show("Время вышло!");
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите корректное значение!");
            }
            SettingTime();

        }
        public void TimeWait(int time)
        {
            for (int i = time; i >= 0; i--)
            {
                Dispatcher.Invoke((Action)(() =>
                {
                    if (i.ToString().Length == 1)
                    {
                        TimeBlock.Text = $"00:00:0{i.ToString()}";
                    }
                    else if (i.ToString().Length == 2)
                    {
                        TimeBlock.Text = $"00:00:{i.ToString()}";
                    }
                }));
                Thread.Sleep(1000);
            }
        }

        private void StartTimer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int time = Convert.ToInt32(Time.Text);
                TimeWait(time);
                MessageBox.Show("Время вышло!");
                
            }
            catch (FormatException)
            {
                MessageBox.Show("Неверный формат!");
            }
            SettingTime();
        }

        private void Time_TextChanged(object sender, TextChangedEventArgs e)
        {
            SettingTime();
        }
        public void SettingTime()
        {
            if (Time.Text.Length == 1)
            {
                TimeBlock.Text = $"00:00:0{Time.Text}";
            }
            else if (Time.Text.Length == 2)
            {
                TimeBlock.Text = $"00:00:{Time.Text}";
            }
            else if(Time.Text.Length == 0)
            {
                TimeBlock.Text = $"00:00:00";
            }
        }
    }
}
