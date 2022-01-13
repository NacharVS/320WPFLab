using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class PhysicСharacteristic : Сharacteristic
    {
        public PhysicСharacteristic(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Update(Strength, Dexterity, Intelligence, Constitution);
        }

        public override void Update(int Strength, int Dexterity, int Intelligence, int Constitution)
        {
            Attack = 3 * Strength + 0.5 * Dexterity;
            Defense = 0.5 * Constitution + 3 * Dexterity;
            CriticalChance = 20 + 0.3 * Constitution;
            CriticalDamage = Attack * (2 + 0.05 * Constitution);
        }
    }
}
