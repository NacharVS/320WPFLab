using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Character
    {
        protected int Strength { get; set; }
        protected int Dexterity { get; set; }
        protected int Intelligence { get; set; }
        protected int Constitution { get; set; }

        protected double Health => 2 * Constitution + 0.5 * Strength;
        protected double Mana => Intelligence * 3;

        protected MagicСharacteristic magic => new MagicСharacteristic(Strength, Dexterity, Intelligence, Constitution);
        protected PhysicСharacteristic physic => new PhysicСharacteristic(Strength, Dexterity, Intelligence, Constitution);

        protected int ExtraPoint = 500;
    }
}
