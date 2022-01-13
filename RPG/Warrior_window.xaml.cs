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
    /// Логика взаимодействия для Warrior_window.xaml
    /// </summary>
    public partial class Warrior_window : Window
    {
        public Warrior_window()
        {
            InitializeComponent();

            TextBox_HP.Text = Par.hp.ToString();
            TextBox_Mana.Text = Par.mana.ToString();
            TextBox_Points.Text = Par.points.ToString();

            TextBox_Stregth.Text = Warrior.strength.ToString();
            TextBox_Dexterity.Text = Warrior.dexterity.ToString();
            TextBox_Intelligence.Text = Warrior.intelligence.ToString();
            TextBox_Constitution.Text = Warrior.constitution.ToString();

            tb1.Text = (Warrior.strength * 3 + 0.5 * Warrior.dexterity).ToString();
            tb2.Text = (Warrior.constitution * 0.5 + Warrior.dexterity * 3).ToString();
            tb3.Text = (Warrior.intelligence * 4).ToString();
            tb4.Text = (Warrior.intelligence * 2).ToString();
            tb5.Text = (20 + Warrior.dexterity * 0.3).ToString();
            tb6.Text = (20 + Warrior.intelligence * 0.1).ToString();
            tb7.Text = ((Warrior.strength * 3 + 0.5 * Warrior.dexterity) * (2 + Warrior.dexterity * 0.5)).ToString();
            tb8.Text = ((Warrior.intelligence * 4) * (2 + Warrior.intelligence * 0.15)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Warrior.Strength_addOrTake(Convert.ToInt32(TextBox_Stregth_add.Text));
            Warrior.Dexterity_addOrTake(Convert.ToInt32(TextBox_Dexterity_add.Text));
            Warrior.Intelligence_addOrTake(Convert.ToInt32(TextBox_Intelligence_add.Text));
            Warrior.Constitution_addOrTake(Convert.ToInt32(TextBox_Constitution_add.Text));

            TextBox_Stregth.Text = Warrior.strength.ToString();
            TextBox_Dexterity.Text = Warrior.dexterity.ToString();
            TextBox_Intelligence.Text = Warrior.intelligence.ToString();
            TextBox_Constitution.Text = Warrior.constitution.ToString();

            tb1.Text = (Warrior.strength * 3 + 0.5 * Warrior.dexterity).ToString();
            tb2.Text = (Warrior.constitution * 0.5 + Warrior.dexterity * 3).ToString();
            tb3.Text = (Warrior.intelligence * 4).ToString();
            tb4.Text = (Warrior.intelligence * 2).ToString();
            tb5.Text = (20 + Warrior.dexterity * 0.3).ToString();
            tb6.Text = (20 + Warrior.intelligence * 0.1).ToString();
            tb7.Text = ((Warrior.strength * 3 + 0.5 * Warrior.dexterity) * (2 + Warrior.dexterity * 0.5)).ToString();
            tb8.Text = ((Warrior.intelligence * 4) * (2 + Warrior.intelligence * 0.15)).ToString();

            TextBox_Points.Text = Par.points.ToString();
        }
    }
}
