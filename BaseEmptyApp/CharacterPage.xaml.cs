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
            TbStrength.Text = character.Strength.ToString();
            TbDexterity.Text = character.Dexterity.ToString();
            TbIntelligence.Text = character.Intelligence.ToString();
            TbConstitution.Text = character.Constitution.ToString();

            TbLabel.Text = character.ToString();
            TbHealth.Text = character.MaxHp.ToString();
            TbMana.Text = character.MaxMp.ToString();

            TbPhAttack.Text = character.PhysicalAttack().ToString();
            TbPhDefense.Text = character.PhysicalAttack().ToString();
            TbPhCritChance.Text = character.PCritChance().ToString();
            TbPhCritDamage.Text = character.PCritDamage().ToString();

            TbMagAttack.Text = character.MagicAttack().ToString();
            TbMagDefense.Text = character.MagicDef().ToString();
            TbMagCritChance.Text = character.MCritChance().ToString();
            TbMagCritDamage.Text = character.MCritDamage().ToString();

            this.DataContext = this;
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                character.Strength = int.Parse(TbStrength.Text);
                character.Dexterity = int.Parse(TbDexterity.Text);
                character.Intelligence = int.Parse(TbIntelligence.Text);
                character.Constitution = int.Parse(TbConstitution.Text);
            }
            catch
            {
                MessageBox.Show("Wrong values");
            }
            NavigationService.Navigate(new CharacterPage(character));
        }
    }
}
