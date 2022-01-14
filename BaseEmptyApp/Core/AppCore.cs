namespace BaseEmptyApp.Core
{
    class AppCore
    {
        public Warrior MakeWarrior()
        {
            Warrior warrior = new Warrior();
            return warrior;
        }

        public Mage MakeMage()
        {
            Mage mage = new Mage();
            return mage;
        }
        public Archer MakeArcher()
        {
            Archer archer = new Archer();
            return archer;
        }
    }
}
