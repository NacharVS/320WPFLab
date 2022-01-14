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
using CharacterLibrary;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public Character Character { get; set; }
        public CharacterPage(Character character)
        {
            InitializeComponent();
            Character = character;
            this.DataContext = this;
        }
    }
}
