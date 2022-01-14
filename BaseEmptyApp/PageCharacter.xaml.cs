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
    /// Логика взаимодействия для PageCharacter.xaml
    /// </summary>
    public partial class PageCharacter : Page
    {
        Character character { get; set; }
        public PageCharacter(Character newCharacter)
        {
            InitializeComponent();
            character = newCharacter;

            this.DataContext = this;
        }
    }
}
