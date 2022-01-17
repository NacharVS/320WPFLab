using Core;

namespace Characters
{
    public class Warrior : Character
    {
        public Warrior()
        {
            Min_Strength = 30;
            Min_Dexterity = 15;
            Min_Intelligence = 10;
            Min_Constitution = 25;

            Max_Strength = 250;
            Max_Dexterity = 80;
            Max_Intelligence = 50;
            Max_Constitution = 100;

            this.Strength = 30;
            this.Dexterity = 15;
            this.Intelligence = 10;
            this.Constitution = 25;
        }
    }
}
