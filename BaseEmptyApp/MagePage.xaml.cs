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
    /// Логика взаимодействия для MagePage.xaml
    /// </summary>
    public partial class MagePage : Page
    {
        Core.Mage person = new Core.Mage(15, 20, 30, 15);
        public MagePage()
        {
            InitializeComponent();
            UpDate();
        }

        private void btn_Arch_Str_Plus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            if (point != 0)
            {
                person.Strength_Plus();
                point--;
                UpDate();
                tbx_Arch_Point.Text = Convert.ToString(point);
            }
        }

        private void btn_Arch_Dex_Plus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            if (point != 0)
            {
                person.Dexterity_Plus();
                point--;
                UpDate();
                tbx_Arch_Point.Text = Convert.ToString(point);
            }
        }

        private void btn_Arch_Int_Plus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            if (point != 0)
            {
                person.Intelligence_Plus();
                point--;
                UpDate();
                tbx_Arch_Point.Text = Convert.ToString(point);
            }
        }

        private void btn_Arch_Con_Plus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            if (point != 0)
            {
                person.Constitution_Plus();
                point--;
                UpDate();
                tbx_Arch_Point.Text = Convert.ToString(point);
            }
        }

        private void btn_Arch_Str_Minus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            person.Strength_Minus();
            point++;
            UpDate();
            tbx_Arch_Point.Text = Convert.ToString(point);
        }

        private void btn_Arch_Dex_Minus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            person.Dexterity_Minus();
            point++;
            UpDate();
            tbx_Arch_Point.Text = Convert.ToString(point);
        }

        private void btn_Arch_Int_Minus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            person.Intelligence_Minus();
            point++;
            UpDate();
            tbx_Arch_Point.Text = Convert.ToString(point);
        }

        private void btn_Arch_Con_Minus_Click(object sender, RoutedEventArgs e)
        {
            int point = Convert.ToInt32(tbx_Arch_Point.Text);
            person.Constitution_Minus();
            point++;
            UpDate();
            tbx_Arch_Point.Text = Convert.ToString(point);
        }

        public void UpDate()
        {
            tb_Arch_Str_txt.Text = Convert.ToString(person.Strength);
            tb_Arch_Int_txt.Text = Convert.ToString(person.Intelligence);
            tb_Arch_Con_txt.Text = Convert.ToString(person.Constitution);
            tb_Arch_Dex_txt.Text = Convert.ToString(person.Dexterity);

            tb_Arch_Helth.Text = Convert.ToString(person.Health);
            tb_Arch_Mana.Text = Convert.ToString(person.Mana);
            tb_Arch_P_Attack.Text = Convert.ToString(person.P_Attack);
            tb_Arch_P_Defense.Text = Convert.ToString(person.P_Defense);
            tb_Arch_M_Attack.Text = Convert.ToString(person.M_Attack);
            tb_Arch_M_Defense.Text = Convert.ToString(person.M_Defense);
            tb_Arch_P_Critical_Chanse.Text = Convert.ToString(person.P_Critical_Chanse);
            tb_Arch_M_Critical_Chanse.Text = Convert.ToString(person.M_Critical_Chanse);
            tb_Arch_P_Critical_Damage.Text = Convert.ToString(person.P_CriticalDamage);
            tb_Arch_M_Critical_Damage.Text = Convert.ToString(person.M_CriticalDamage);
        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
