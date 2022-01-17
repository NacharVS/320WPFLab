using Core;

namespace Characters
{
    public class Archer : Character
    {
        public Archer()
        {
            Min_Strength = 20;
            Min_Dexterity = 30;
            Min_Intelligence = 15;
            Min_Constitution = 20;

            Max_Strength = 55;
            Max_Dexterity = 250;
            Max_Intelligence = 70;
            Max_Constitution = 70;

            this.Strength = 20;
            this.Dexterity = 30;
            this.Intelligence = 15;
            this.Constitution = 20;
        }
    }
}
