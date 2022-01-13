using System;

namespace Core
{
    abstract public class Character
    {
        private int strength;
        public int Strength { get => strength; set => strength = value;  }

        private int dexterity;
        public int Dexterity { get => dexterity; set => dexterity = value;  }

        private int intelligence;
        public int Intelligence { get => intelligence; set => intelligence = value; }

        private int constitution;
        public int Constitution { get => constitution; set => constitution = value; }

        private double health => 2 * Constitution + 0.5 * Strength;
        public double Health { get { return health; } }

        private double mana => Intelligence * 3;
        public double Mana { get { return mana; } }

        private PhysicalStats physical => new PhysicalStats(Strength, Dexterity, Intelligence, Constitution);
        public PhysicalStats Physical { get { return physical; } }

        private MagicalStats magical => new MagicalStats(Strength, Dexterity, Intelligence, Constitution);
        public MagicalStats Magical { get { return magical; } }
    }
}
