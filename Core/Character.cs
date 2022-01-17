using System;

namespace Core
{
    public abstract class Character
    {
        public string imgCharacter;

        private int strength;
        public int MinStrength { get; set; }
        public int MaxStrength { get; set; }
        public int Strength { get => strength; 
            set
            {
                if (value >= MinStrength && value <= MaxStrength)
                    strength = value;
                else
                    throw new Exception("!!!!!");
            }
        }

        private int dexterity;
        public int MinDexterity { get; set; }
        public int MaxDexterity { get; set; }
        public int Dexterity { get => dexterity; 
            set
            {
                if (value >= MinDexterity && value <= MaxDexterity)
                    dexterity = value;
                else
                    throw new Exception("!!!!!");
            }
        }

        private int intelligence;
        public int MinIntelligence { get; set; }
        public int MaxIntelligence { get; set; }
        public int Intelligence { get => intelligence; 
            set
            {
                if (value >= MinIntelligence && value <= MaxIntelligence)
                    intelligence = value;
                else
                    throw new Exception("!!!!!");
            }
        }

        private int constitution;
        public int MinConstitution { get; set; }
        public int MaxConstitution { get; set; }
        public int Constitution { get => constitution; set
            {
                if (value >= MinConstitution && value <= MaxConstitution)
                    constitution = value;
                else
                    throw new Exception("!!!!!");
            }
        }

        private double health => 2 * Constitution + 0.5 * Strength;
        public double Health { get { return health; } }

        private double mana => Intelligence * 3;
        public double Mana { get { return mana; } }

        private PhysicalStats physical => new PhysicalStats(Strength, Dexterity, Intelligence, Constitution);
        public PhysicalStats Physical { get { return physical; } }

        private MagicalStats magical => new MagicalStats(Strength, Dexterity, Intelligence, Constitution);
        public MagicalStats Magical { get { return magical; } }

        public int ExtraPoint { get; set; } = 5;
    }
}
