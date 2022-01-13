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
    /// Логика взаимодействия для Mage_window.xaml
    /// </summary>
    public partial class Mage_window : Window
    {
        public Mage_window()
        {
            InitializeComponent();

            TextBox_HP.Text = Par.hp.ToString();
            TextBox_Mana.Text = Par.mana.ToString();
            TextBox_Points.Text = Par.points.ToString();

            TextBox_Stregth.Text = Mage.strength.ToString();
            TextBox_Dexterity.Text = Mage.dexterity.ToString();
            TextBox_Intelligence.Text = Mage.intelligence.ToString();
            TextBox_Constitution.Text = Mage.constitution.ToString();

            tb1.Text = (Mage.strength * 3 + 0.5 * Mage.dexterity).ToString();
            tb2.Text = (Mage.constitution * 0.5 + Mage.dexterity * 3).ToString();
            tb3.Text = (Mage.intelligence * 4).ToString();
            tb4.Text = (Mage.intelligence * 2).ToString();
            tb5.Text = (20 + Mage.dexterity * 0.3).ToString();
            tb6.Text = (20 + Mage.intelligence * 0.1).ToString();
            tb7.Text = ((Mage.strength * 3 + 0.5 * Mage.dexterity) * (2 + Mage.dexterity * 0.5)).ToString();
            tb8.Text = ((Mage.intelligence * 4) * (2 + Mage.intelligence * 0.15)).ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Mage.Strength_addOrTake(Convert.ToInt32(TextBox_Stregth_add.Text));
            Mage.Dexterity_addOrTake(Convert.ToInt32(TextBox_Dexterity_add.Text));
            Mage.Intelligence_addOrTake(Convert.ToInt32(TextBox_Intelligence_add.Text));
            Mage.Constitution_addOrTake(Convert.ToInt32(TextBox_Constitution_add.Text));

            TextBox_Stregth.Text = Mage.strength.ToString();
            TextBox_Dexterity.Text = Mage.dexterity.ToString();
            TextBox_Intelligence.Text = Mage.intelligence.ToString();
            TextBox_Constitution.Text = Mage.constitution.ToString();

            tb1.Text = (Mage.strength * 3 + 0.5 * Mage.dexterity).ToString();
            tb2.Text = (Mage.constitution * 0.5 + Mage.dexterity * 3).ToString();
            tb3.Text = (Mage.intelligence * 4).ToString();
            tb4.Text = (Mage.intelligence * 2).ToString();
            tb5.Text = (20 + Mage.dexterity * 0.3).ToString();
            tb6.Text = (20 + Mage.intelligence * 0.1).ToString();
            tb7.Text = ((Mage.strength * 3 + 0.5 * Mage.dexterity) * (2 + Mage.dexterity * 0.5)).ToString();
            tb8.Text = ((Mage.intelligence * 4) * (2 + Mage.intelligence * 0.15)).ToString();

            TextBox_Points.Text = Par.points.ToString();
        }
    }
}
