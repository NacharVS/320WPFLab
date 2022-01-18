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
            if(unit.ExtraPoint != 0 && unit.Strength < unit.MaxStrength)
            {
                unit.Strength += 1;
                unit.ExtraPoint = 1;
            }
        }

        public void UpDexterity(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 && unit.Dexterity < unit.MaxDexterity)
            {
                unit.Dexterity += 1;
                unit.ExtraPoint = 1;
            }
        }

        public void UpIntelligence(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 && unit.Intelligence < unit.MaxIntelligence)
            {
                unit.Intelligence += 1;
                unit.ExtraPoint = 1;
            }
        }

        public void UpConstitution(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 && unit.Constitution < unit.MaxConstitution)
            {
                unit.Constitution += 1;
                unit.ExtraPoint = 1;
            }
        }

        public void DownStrength(ref BaseUnit unit)
        {
            if(unit.ExtraPoint != 0 & unit.Strength > unit.MinStrength)
            {
                unit.Strength -= 1;
                unit.ExtraPoint = -1;
            }
        }

        public void DownDexterity(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 & unit.Dexterity > unit.MinDexterity)
            {
                unit.Dexterity -= 1;
                unit.ExtraPoint = -1;
            }
        }

        public void DownIntelligence(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 & unit.Intelligence > unit.MinIntelligence)
            {
                unit.Intelligence -= 1;
                unit.ExtraPoint = -1;
            }
        }

        public void DownConstitution(ref BaseUnit unit)
        {
            if (unit.ExtraPoint != 0 & unit.Constitution > unit.MinConstitution)
            {
                unit.Constitution -= 1;
                unit.ExtraPoint = -1;
            }
        }

        public void UpExtraPoints(ref BaseUnit unit)
        {
            unit.ExtraPoint = -10;
        }
    }
}
