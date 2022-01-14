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
            Name.Text = MainWindow.character;
            dexterity.Text = Unit.Dexterity.ToString();
            strengh.Text = Unit.Strength.ToString();
            constitution.Text = Unit.Constitution.ToString();
            intellegence.Text = Unit.Intelligence.ToString();
            Health.Text = Unit.Health.ToString();
            Mana.Text = Unit.Mana.ToString();
            PAttack.Text = Unit.Physic.Attack.ToString();
            PDefense.Text = Unit.Physic.Defense.ToString();
            MAttack.Text = Unit.Magic.Attack.ToString();
            MDefense.Text = Unit.Magic.Defense.ToString();
            PCryticalDefence.Text = Unit.Physic.Defense.ToString();
            MCryticalDefence.Text = Unit.Magic.Defense.ToString();
            PCryticalDamage.Text = Unit.Physic.CriticalDamage.ToString();
            MCryticalDamage.Text = Unit.Magic.CriticalDamage.ToString();
            Extra_Points.Text = Unit.ExtraPoint.ToString();
            this.DataContext = this;
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void StrengthMinus_Click(object sender, RoutedEventArgs e)
        {
            if(Unit.Strength > Unit.MinStrength)
            {
                Unit.Strength--;
                strengh.Text = Unit.Strength.ToString();
                Refreshing();
            }
            else
            {
                MessageBox.Show("Strength is minimal already");
            }
        }

        private void DexterityMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.Dexterity > Unit.MinDexterity)
            {
                Unit.Dexterity--;
                dexterity.Text = Unit.Dexterity.ToString();
                Refreshing();
            }
            else
            {
                MessageBox.Show("Dexterity is minimal already");
            }
        }

        private void IntellegenceMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.Intelligence > Unit.MinIntelligence)
            {
                Unit.Intelligence--;
                intellegence.Text = Unit.Intelligence.ToString();
                Refreshing();
            }
            else
            {
                MessageBox.Show("Intelligence is minimal already");
            }
        }

        private void ConstitutionMinus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.Constitution > Unit.MinConstitution)
            {
                Unit.Constitution--;
                constitution.Text = Unit.Constitution.ToString();
                Refreshing();
            }
            else
            {
                MessageBox.Show("Constitution is minimal already");
            }
        }

        private void Extra_Points_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void StrengthPlus_Click(object sender, RoutedEventArgs e)
        {
            if(Unit.ExtraPoint !=0)
            {
                if (Unit.Strength < Unit.MaxStrength)
                {
                    Unit.Strength++;
                    strengh.Text = Unit.Strength.ToString();
                    Unit.ExtraPoint--;
                    Extra_Points.Text = Unit.ExtraPoint.ToString();
                    Refreshing();
                }
                else
                {
                    MessageBox.Show("Strength is max");
                }
            }
            else
            {
                MessageBox.Show("No more extra points");
            }
        }
        public void Refreshing()
        {
            Health.Text = Unit.Health.ToString();
            PAttack.Text = Unit.Physic.Attack.ToString();
            PDefense.Text = Unit.Physic.Defense.ToString();
            MAttack.Text = Unit.Magic.Attack.ToString();
            MDefense.Text = Unit.Magic.Defense.ToString();
            PCryticalDefence.Text = Unit.Physic.Defense.ToString();
            MCryticalDefence.Text = Unit.Magic.Defense.ToString();
            PCryticalDamage.Text = Unit.Physic.CriticalDamage.ToString();
            MCryticalDamage.Text = Unit.Magic.CriticalDamage.ToString();
            Mana.Text = Unit.Mana.ToString();
        }

        private void IntellegencePlus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.ExtraPoint != 0)
            {
                if (Unit.Intelligence < Unit.MaxIntelligence)
                {
                    Unit.Intelligence++;
                    intellegence.Text = Unit.Intelligence.ToString();
                    Unit.ExtraPoint--;
                    Extra_Points.Text = Unit.ExtraPoint.ToString();
                    Refreshing();
                }
                else
                {
                    MessageBox.Show("Intelligence is max");
                }
            }
            else
            {
                MessageBox.Show("No more extra points");
            }
        }

        private void DexterityPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.ExtraPoint != 0)
            {
                if (Unit.Dexterity < Unit.MaxDexterity && Unit.ExtraPoint != 0)
                {
                    Unit.Dexterity++;
                    dexterity.Text = Unit.Dexterity.ToString();
                    Unit.ExtraPoint--;
                    Extra_Points.Text = Unit.ExtraPoint.ToString();
                    Refreshing();
                }
                else
                {
                    MessageBox.Show("Dexterity is max");
                }
            }
            else
            {
                MessageBox.Show("No more extra points");
            }
        }

        private void ConstitutionPlus_Click(object sender, RoutedEventArgs e)
        {
            if (Unit.ExtraPoint != 0)
            {
                if (Unit.Constitution < Unit.MaxConstitution && Unit.ExtraPoint != 0)
                {
                    Unit.Constitution++;
                    constitution.Text = Unit.Constitution.ToString();
                    Unit.ExtraPoint--;
                    Extra_Points.Text = Unit.ExtraPoint.ToString();
                    Refreshing();
                }
                else
                {
                    MessageBox.Show("Constitution is max");
                }
            }
            else
            {
                MessageBox.Show("No more extra points");
            }
        }
    }
}
