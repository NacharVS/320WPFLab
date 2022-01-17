using Core;

namespace Characters
{
    public class Mage : Character
    {
        public Mage()
        {
            Min_Strength = 15;
            Min_Dexterity = 20;
            Min_Intelligence = 30;
            Min_Constitution = 15;

            Max_Strength = 45;
            Max_Dexterity = 70;
            Max_Intelligence = 70;
            Max_Constitution = 70;

            this.Strength = 15;
            this.Dexterity = 20;
            this.Intelligence = 30;
            this.Constitution = 15;
        }
    }
}
