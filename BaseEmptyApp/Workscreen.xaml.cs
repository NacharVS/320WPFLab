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
using Core;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for Workscreen.xaml
    /// </summary>
    public partial class Workscreen : Page
    {
        private int ExtraPointsValue;
        
        public Workscreen()
        {
            InitializeComponent();
            ExtraPointsValue = 0;


        }

        private void StrengthAddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DextAddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IntAddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConstAddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void StrengthRemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DextRemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void IntRemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConstRemoveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExtraPointsAddButton_Click(object sender, RoutedEventArgs e)
        {
            ExtraPoints.Text = (ExtraPointsValue + 10).ToString();
            ExtraPointsValue += 10;
        }
    }
}
