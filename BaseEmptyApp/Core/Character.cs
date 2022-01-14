using System;
using System.Collections.Generic;
using System.Text;

namespace BaseEmptyApp.Core
{
    public abstract class Character
    {
        private int strength;
        public int Strength { get => strength; set => strength = value; }

        private int dexterity;
        public int Dexterity { get => dexterity; set => dexterity = value; }

        private int intelligence;
        public int Intelligence { get => intelligence; set => intelligence = value; }

        private int constitution;
        public int Constitution { get => constitution; set => constitution = value; }

        private double health => 2 * Constitution + 0.5 * Strength;
        public double Health { get { return health; } }

        private double mana => Intelligence * 3;
        public double Mana { get { return mana; } }

        private PhysicStatistics physic => new PhysicStatistics(Strength, Dexterity, Intelligence, Constitution);
        public PhysicStatistics Physic { get { return physic; } }

        private MagicStatistics magic => new MagicStatistics(Strength, Dexterity, Intelligence, Constitution);
        public MagicStatistics Magic { get { return magic; } }
    }
}
