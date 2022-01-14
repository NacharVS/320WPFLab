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
using System.Windows.Shapes;
using CharacterCore;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для Editor.xaml
    /// </summary>
    public partial class Editor : Window
    {
        public Unit Unit { get; set; }
        public Editor(Unit unit)
        {
            InitializeComponent();
            Unit = unit;
            this.DataContext = this;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Name.Text = MainWindow.character;
            dexterity.Text = Unit.Dexterity.ToString();
            strengh.Text = Unit.Strength.ToString();
            constitution.Text = Unit.Constitution.ToString();
            intellegence.Text = Unit.Intelligence.ToString();
        }

        private void StrengthMinus_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DexterityMinus_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
