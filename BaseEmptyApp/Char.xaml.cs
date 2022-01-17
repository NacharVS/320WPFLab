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
using Core;

namespace BaseEmptyApp
{
    /// <summary>
    /// Логика взаимодействия для Char.xaml
    /// </summary>
    public partial class Char : Window
    {
        public Character Character { get; set; }
        public Char(Character character)
        {
            InitializeComponent();
            Character = character;
            name.Text = character.Name;
            strengh.Text = character.Strength.ToString();
            dexterity.Text = character.Dexterity.ToString();
            intellegence.Text = character.Intelligence.ToString();
            constitution.Text = character.Constitution.ToString();
            Health.Text = character._health.ToString();
            Mana.Text = character._mana.ToString();
            Extra_Points.Text = character._extrapoints.ToString();
            PAttack.Text = character._physicalAttack.ToString();
            MAttack.Text = character._magicalAttack.ToString();
            PDefense.Text = character._physicalDefense.ToString();
            MDefense.Text = character._magicalDefense.ToString();
            PCryticalChance.Text = character._physicalCritChance.ToString();
            MCryticalChance.Text = character._magicalCritChance.ToString();
            PCryticalDamage.Text = character._physicalCritDamage.ToString();
            MCryticalDamage.Text = character._magicalCritDamage.ToString();
            this.DataContext = this;
        }

        private void BlockRefresh()
        {
            strengh.Text = Character.Strength.ToString();
            dexterity.Text = Character.Dexterity.ToString();
            intellegence.Text = Character.Intelligence.ToString();
            constitution.Text = Character.Constitution.ToString();
            Health.Text = Character._health.ToString();
            PAttack.Text = Character._physicalAttack.ToString();
            PDefense.Text = Character._physicalDefense.ToString();
            MAttack.Text = Character._magicalAttack.ToString();
            MDefense.Text = Character._magicalDefense.ToString();
            PCryticalChance.Text = Character._physicalCritChance.ToString();
            MCryticalChance.Text = Character._magicalCritChance.ToString();
            PCryticalDamage.Text = Character._physicalCritDamage.ToString();
            MCryticalDamage.Text = Character._magicalCritDamage.ToString();
            Mana.Text = Character._mana.ToString();
            Extra_Points.Text = Character._extrapoints.ToString();
        }

        private void StrengthMinus_Click(object sender, RoutedEventArgs e)
        {
            Character.DecreaseStrength();
            BlockRefresh();
        }

        private void StrengthPlus_Click(object sender, RoutedEventArgs e)
        {
            Character.IncreaseStrength();
            BlockRefresh();
        }

        private void DexterityMinus_Click(object sender, RoutedEventArgs e)
        {
            Character.DecreaseDexterity();
            BlockRefresh();
        }

        private void DexterityPlus_Click(object sender, RoutedEventArgs e)
        {
            Character.IncreaseDexterity();
            BlockRefresh();
        }

        private void IntellegenceMinus_Click(object sender, RoutedEventArgs e)
        {
            Character.DecreaseIntelligence();
            BlockRefresh();
        }

        private void IntellegencePlus_Click(object sender, RoutedEventArgs e)
        {
            Character.IncreaseIntelligence();
            BlockRefresh();
        }

        private void ConstitutionMinus_Click(object sender, RoutedEventArgs e)
        {
            Character.DecreaseConstitution();
            BlockRefresh();
        }

        private void ConstitutionPlus_Click(object sender, RoutedEventArgs e)
        {
            Character.IncreaseConstitution();
            BlockRefresh();
        }

        private void strengh_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void dexterity_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void intellegence_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void constitution_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Health_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Mana_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Extra_Points_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PAttack_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MAttack_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PDefense_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MDefense_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PCryticalDefence_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MCryticalDefence_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PCryticalDamage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MCryticalDamage_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
