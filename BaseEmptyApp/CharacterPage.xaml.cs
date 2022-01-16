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
    /// Логика взаимодействия для CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        private static Character character { get; set; }

        public CharacterPage(Character ch)
        {
            InitializeComponent();
            character = ch;
            UpdateCharacter();
        }
        private bool Change()
        {
            if (Case.EP > 0)
            {
                Case.EP--;
                return true;
            }
            else MessageBox.Show("No extra points");
            return false;
        }
        private void UpdateCharacter()
        {
            TbStrength.Text = character.Strength.ToString();
            TbDexterity.Text = character.Dexterity.ToString();
            TbIntelligence.Text = character.Intelligence.ToString();
            TbConstitution.Text = character.Constitution.ToString();

            TbLabel.Text = character.ToString();
            TbHealth.Text = character.GetHp().ToString();
            TbMana.Text = character.GetMana().ToString();

            TbPhAttack.Text = character.PhysicalAttack().ToString();
            TbPhDefense.Text = character.PhysicalAttack().ToString();
            TbPhCritChance.Text = Math.Round(character.PCritChance(), 2).ToString();
            TbPhCritDamage.Text = Math.Round(character.PCritDamage(), 2).ToString();

            TbMagAttack.Text = character.MagicAttack().ToString();
            TbMagDefense.Text = character.MagicDef().ToString();
            TbMagCritChance.Text =  Math.Round(character.MCritChance(), 2).ToString();
            TbMagCritDamage.Text = Math.Round(character.MCritDamage(), 2).ToString();


            this.DataContext = this;
        }

        private void plusCon_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Change()) 
            {
                character.Constitution += 1;
                UpdateCharacter();
            }
        }

        private void plusInt_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Change())
            {
                character.Intelligence += 1;
                UpdateCharacter();
            }
        }

        private void plusDex_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Change())
            {
                character.Dexterity += 1;
                UpdateCharacter();
            }
        }

        private void plusStr_btn_Click(object sender, RoutedEventArgs e)
        {
            if (Change())
            {
                character.Strength += 1;
                UpdateCharacter();
            }
        }

        private void minusStr_btn_Click(object sender, RoutedEventArgs e)
        {
            character.Strength -= 1;
            UpdateCharacter();
        }

        private void minusDex_btn_Click(object sender, RoutedEventArgs e)
        {
            character.Dexterity -= 1;
            UpdateCharacter();
        }

        private void minusInt_btn_Click(object sender, RoutedEventArgs e)
        {
            character.Intelligence -= 1;
            UpdateCharacter();
        }

        private void minusCon_btn_Click(object sender, RoutedEventArgs e)
        {
            character.Constitution -= 1;
            UpdateCharacter();
        }
    }
}
