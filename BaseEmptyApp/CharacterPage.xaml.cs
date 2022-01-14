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
using CharacterLibrary;

namespace BaseEmptyApp
{
    /// <summary>
    /// Interaction logic for CharacterPage.xaml
    /// </summary>
    public partial class CharacterPage : Page
    {
        public Character Character { get; set; }
        public CharacterPage(Character character)
        {
            InitializeComponent();
            Character = character;
            TbLabel.Text = Character.ToString();
            TbHealth.Text = Character.Health.ToString();
            TbMana.Text = Character.Mana.ToString();

            TbPhAttack.Text = Character.Physic.Attack.ToString();
            TbPhDefense.Text = Character.Physic.Defense.ToString();
            TbPhCritChance.Text = Character.Physic.CriticalChance.ToString();
            TbPhCritDamage.Text = Character.Physic.CriticalDamage.ToString();

            TbMagAttack.Text = Character.Magic.Attack.ToString();
            TbMagDefense.Text = Character.Magic.Defense.ToString();
            TbMagCritChance.Text = Character.Magic.CriticalChance.ToString();
            TbMagCritDamage.Text = Character.Magic.CriticalDamage.ToString();

            this.DataContext = this;
        }

        private void BtnChange_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Character.Strength = int.Parse(TbStrength.Text);
                Character.Dexterity = int.Parse(TbDexterity.Text);
                Character.Intelligence = int.Parse(TbIntelligence.Text);
                Character.Constitution = int.Parse(TbConstitution.Text);
            }
            catch
            {
                MessageBox.Show("Wrong values");
            }
            NavigationService.Navigate(new CharacterPage(Character));

        }
    }
}
