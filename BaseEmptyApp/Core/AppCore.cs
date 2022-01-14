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

        public void UpStrength(ref BaseUnit unit)
        {
            unit.Strength += 1;
            unit.ExtraPoint = 1;
        }

        public void UpDexterity(ref BaseUnit unit)
        {
            unit.Dexterity += 1;
            unit.ExtraPoint = 1;
        }

        public void UpIntelligence(ref BaseUnit unit)
        {
            unit.Intelligence += 1;
            unit.ExtraPoint = 1;
        }

        public void UpConstitution(ref BaseUnit unit)
        {
            unit.Constitution += 1;
            unit.ExtraPoint = 1;
        }

        public void DownStrength(ref BaseUnit unit)
        {
            unit.Strength -= 1;
            unit.ExtraPoint = 1;
        }

        public void DownDexterity(ref BaseUnit unit)
        {
            unit.Dexterity -= 1;
            unit.ExtraPoint = 1;
        }

        public void DownIntelligence(ref BaseUnit unit)
        {
            unit.Intelligence -= 1;
            unit.ExtraPoint = 1;
        }

        public void DownConstitution(ref BaseUnit unit)
        {
            unit.Constitution -= 1;
            unit.ExtraPoint = 1;
        }

    }
}
