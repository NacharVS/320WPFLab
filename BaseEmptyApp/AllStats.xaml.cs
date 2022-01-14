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
using CoreLibrary;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для AllStats.xaml
    /// </summary>
    public partial class AllStats : Window
    {
        public AllStats()
        {
            InitializeComponent();
            CoreLibrary.Globals.character.CalculateStats();
            if (CoreLibrary.Globals.character.Health < 0.5 * CoreLibrary.Globals.character.maxHealth)
                CoreLibrary.Globals.character.HealthDebaff();
            if (CoreLibrary.Globals.character.Mana < 0.2 * CoreLibrary.Globals.character.maxMana)
                CoreLibrary.Globals.character.ManaDebaff();

            lb_health.Content = CoreLibrary.Globals.character.Health;
            lb_mana.Content = CoreLibrary.Globals.character.Mana;
            lb_pAttack.Content = CoreLibrary.Globals.character.pAttack;
            lb_mAttack.Content = CoreLibrary.Globals.character.mAttack;
            lb_pDefense.Content = CoreLibrary.Globals.character.pDefense;
            lb_mDefense.Content = CoreLibrary.Globals.character.mDefense;
            lb_pCC.Content = CoreLibrary.Globals.character.pCriticalChanse;
            lb_mCC.Content = CoreLibrary.Globals.character.mCriticalChanse;
            lb_pCD.Content = CoreLibrary.Globals.character.pCriticalDamage;
            lb_mCD.Content = CoreLibrary.Globals.character.mCriticalDamage;


        }

        private void btn_back_Click(object sender, RoutedEventArgs e)
        {
            ChangeStats changeStats = new ChangeStats();
            changeStats.Show();
            Close();
        }
    }
}
