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

namespace BaseEmptyApp.pages
{
    /// <summary>
    /// Interaction logic for page_character_selection.xaml
    /// </summary>
    public partial class page_character_selection : Page
    {
        public page_character_selection()
        {
            InitializeComponent();
        }

        private void authoriz_click_event(object sender, RoutedEventArgs e)
        {
            switch (character_class.SelectedItem)
            {
                case "Warrior":
                    //MessageBox.Show($"Welcome Warrior");
                    
                    NavigationService.Navigate(new pages.page_info());
                    break;

                case "Mage":
                    //MessageBox.Show($"Welcome Mage");

                    NavigationService.Navigate(new pages.page_info());
                    break;

                case "Archer":
                    //MessageBox.Show($"Welcome Archer");

                    NavigationService.Navigate(new pages.page_info());
                    break;

                default:
                    //Ошибка - "Не выбрано"
                    MessageBox.Show($"Не выбрано");
                    break;
            }
        }
    }
}
