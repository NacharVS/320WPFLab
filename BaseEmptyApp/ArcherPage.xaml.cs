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
    /// Логика взаимодействия для ArcherPage.xaml
    /// </summary>
    public partial class ArcherPage : Page
    {
        private int ExtraPointsValue;
        private Archer character;
        public ArcherPage(Archer temp)
        {
            InitializeComponent();
            ExtraPointsValue = 0;
            character = temp;

            CharacterStrengthPoints.Text = character.Strength.ToString();
            CharacterDextPoints.Text = character.Dexterity.ToString();
            CharacterIntPoints.Text = character.Intelligence.ToString();
            CharacterConstPoints.Text = character.Constitution.ToString();

            HealthPoints.Text = character.Health.ToString();
            ManaPoints.Text = character.Mana.ToString();
            PhysAtkPoints.Text = character.GetPhysAttack().ToString();
            PhysResPoints.Text = character.GetPhysDefense().ToString();
            MagicAtkPoints.Text = character.GetMagicAttack().ToString();
            MagicResPoints.Text = character.GetMagicDefence().ToString();
            PhysCrChsncePoints.Text = character.GetPhysCritChance().ToString();
            MagicCrChancePoints.Text = character.GetMagicCritChance().ToString();
            PhysCrDamPoints.Text = character.GetPhysCritDamage().ToString();
            MagicCrDamPoints.Text = character.GetMagicCritDamage().ToString();
        }
        private void StrengthAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.AddStrength() == true && ExtraPointsValue > 0)
            {
                ExtraPointsValue--;
                ExtraPoints.Text = ExtraPointsValue.ToString();
                CharacterStrengthPoints.Text = character.Strength.ToString();
            }
            else
            {
                character.RemoveStrength();
            }

            HealthPoints.Text = character.GetMaxHealth().ToString();
            PhysAtkPoints.Text = character.GetPhysAttack().ToString();
            PhysCrDamPoints.Text = character.GetPhysCritDamage().ToString();
        }

        private void DextAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.AddDext() == true && ExtraPointsValue > 0)
            {
                ExtraPointsValue--;
                ExtraPoints.Text = ExtraPointsValue.ToString();
                CharacterDextPoints.Text = character.Dexterity.ToString();
            }
            else
            {
                character.RemoveDext();
            }
            PhysAtkPoints.Text = character.GetPhysAttack().ToString();
            PhysResPoints.Text = character.GetPhysDefense().ToString();
            PhysCrChsncePoints.Text = character.GetPhysCritChance().ToString();
            PhysCrDamPoints.Text = character.GetPhysCritDamage().ToString();
        }

        private void IntAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.AddInt() == true && ExtraPointsValue > 0)
            {
                ExtraPointsValue--;
                ExtraPoints.Text = ExtraPointsValue.ToString();
                CharacterIntPoints.Text = character.Intelligence.ToString();
            }
            else
            {
                character.RemoveInt();
            }
            ManaPoints.Text = character.Mana.ToString();
            MagicAtkPoints.Text = character.GetMagicAttack().ToString();
            MagicResPoints.Text = character.GetMagicDefence().ToString();
            MagicCrChancePoints.Text = character.GetMagicCritChance().ToString();
            MagicCrDamPoints.Text = character.GetMagicCritDamage().ToString();
        }

        private void ConstAddButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.AddConst() == true && ExtraPointsValue > 0)
            {
                ExtraPointsValue--;
                ExtraPoints.Text = ExtraPointsValue.ToString();
                CharacterConstPoints.Text = character.Constitution.ToString();
            }
            else
            {
                character.RemoveConst();
            }
            HealthPoints.Text = character.GetMaxHealth().ToString();
            PhysResPoints.Text = character.GetPhysDefense().ToString();
        }

        private void StrengthRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.RemoveStrength() == true)
            {
                CharacterStrengthPoints.Text = character.Strength.ToString();
            }
            else
            {
                character.AddStrength();
            }

            HealthPoints.Text = character.GetMaxHealth().ToString();
            PhysAtkPoints.Text = character.GetPhysAttack().ToString();
            PhysCrDamPoints.Text = character.GetPhysCritDamage().ToString();
        }

        private void DextRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.RemoveDext() == true)
            {
                CharacterDextPoints.Text = character.Dexterity.ToString();
            }
            else
            {
                character.AddDext();
            }
            PhysAtkPoints.Text = character.GetPhysAttack().ToString();
            PhysResPoints.Text = character.GetPhysDefense().ToString();
            PhysCrChsncePoints.Text = character.GetPhysCritChance().ToString();
            PhysCrDamPoints.Text = character.GetPhysCritDamage().ToString();
        }

        private void IntRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.RemoveInt() == true)
            {
                CharacterIntPoints.Text = character.Intelligence.ToString();
            }
            else
            {
                character.AddInt();
            }
            ManaPoints.Text = character.Mana.ToString();
            MagicAtkPoints.Text = character.GetMagicAttack().ToString();
            MagicResPoints.Text = character.GetMagicDefence().ToString();
            MagicCrChancePoints.Text = character.GetMagicCritChance().ToString();
            MagicCrDamPoints.Text = character.GetMagicCritDamage().ToString();
        }

        private void ConstRemoveButton_Click(object sender, RoutedEventArgs e)
        {
            if (character.RemoveConst() == true)
            {
                CharacterConstPoints.Text = character.Constitution.ToString();
            }
            else
            {
                character.AddConst();
            }
            HealthPoints.Text = character.GetMaxHealth().ToString();
            PhysResPoints.Text = character.GetPhysDefense().ToString();
        }

        private void ExtraPointsAddButton_Click(object sender, RoutedEventArgs e)
        {
            ExtraPoints.Text = (ExtraPointsValue + 10).ToString();
            ExtraPointsValue += 10;
        }
    }
}
