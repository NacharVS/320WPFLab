using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public abstract class Сharacteristic
    {
        protected double Attack { get; set; }
        protected double Defense { get; set; }
        protected double CriticalChance { get; set; }
        protected double CriticalDamage { get; set; }
        public abstract void Update(int Strength, int Dexterity, int Intelligence, int Constitution);
    }
}
