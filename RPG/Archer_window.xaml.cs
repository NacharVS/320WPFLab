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
using System.Windows.Shapes;

namespace RPG
{
    /// <summary>
    /// Логика взаимодействия для Archer_window.xaml
    /// </summary>
    public partial class Archer_window : Window
    {
        public Archer_window()
        {
            InitializeComponent();

            TextBox_HP.Text = Par.hp.ToString();
            TextBox_Mana.Text = Par.mana.ToString();
            TextBox_Points.Text = Par.points.ToString();

            TextBox_Stregth.Text = Archer.strength.ToString();
            TextBox_Dexterity.Text = Archer.dexterity.ToString();
            TextBox_Intelligence.Text = Archer.intelligence.ToString();
            TextBox_Constitution.Text = Archer.constitution.ToString();

            tb1.Text = (Archer.strength * 3 + 0.5 * Archer.dexterity).ToString();
            tb2.Text = (Archer.constitution * 0.5 + Archer.dexterity * 3).ToString();
            tb3.Text = (Archer.intelligence * 4).ToString();
            tb4.Text = (Archer.intelligence * 2).ToString();
            tb5.Text = (20 + Archer.dexterity * 0.3).ToString();
            tb6.Text = (20 + Archer.intelligence * 0.1).ToString();
            tb7.Text = ((Archer.strength * 3 + 0.5 * Archer.dexterity) * (2 + Archer.dexterity * 0.5)).ToString();
            tb8.Text = ((Archer.intelligence * 4) * (2 + Archer.intelligence * 0.15)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Archer.Strength_addOrTake(Convert.ToInt32(TextBox_Stregth_add.Text));
            Archer.Dexterity_addOrTake(Convert.ToInt32(TextBox_Dexterity_add.Text));
            Archer.Intelligence_addOrTake(Convert.ToInt32(TextBox_Intelligence_add.Text));
            Archer.Constitution_addOrTake(Convert.ToInt32(TextBox_Constitution_add.Text));

            TextBox_Stregth.Text = Archer.strength.ToString();
            TextBox_Dexterity.Text = Archer.dexterity.ToString();
            TextBox_Intelligence.Text = Archer.intelligence.ToString();
            TextBox_Constitution.Text = Archer.constitution.ToString();

            tb1.Text = (Archer.strength * 3 + 0.5 * Archer.dexterity).ToString();
            tb2.Text = (Archer.constitution * 0.5 + Archer.dexterity * 3).ToString();
            tb3.Text = (Archer.intelligence * 4).ToString();
            tb4.Text = (Archer.intelligence * 2).ToString();
            tb5.Text = (20 + Archer.dexterity * 0.3).ToString();
            tb6.Text = (20 + Archer.intelligence * 0.1).ToString();
            tb7.Text = ((Archer.strength * 3 + 0.5 * Archer.dexterity) * (2 + Archer.dexterity * 0.5)).ToString();
            tb8.Text = ((Archer.intelligence * 4) * (2 + Archer.intelligence * 0.15)).ToString();

            TextBox_Points.Text = Par.points.ToString();
        }
    }
}
