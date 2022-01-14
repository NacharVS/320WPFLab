namespace BaseEmptyApp.Core
{
    abstract class BaseUnit
    {
        protected int minStrenght { get; set; }
        protected int maxStrenght { get; set; }
        protected int minDexterity { get; set; }
        protected int maxDexterity { get; set; }
        protected int minIntelligence { get; set; }
        protected int maxIntelligence { get; set; }
        protected int minConstitution { get; set; }
        protected int maxConstitution { get; set; }

        int extraPoints = 5;
        protected int Constitution;
        protected int Strength;
        protected int Dexterity;
        protected int Intelligence;

        double Health;
        double Mana;

        public BaseUnit()
        {
            Strength = minStrenght;
            Dexterity = minDexterity;
            Intelligence = minIntelligence;
            Constitution = minConstitution;
            Health = 2 * Constitution + 0.5 * Strength;
            Mana = Intelligence * 3;
        }
    }


}
