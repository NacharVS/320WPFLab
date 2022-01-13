using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Character
    {
        int Strength { get; set; }
        int Dexterity { get; set; }
        int Intelligence { get; set; }
        int Constitution { get; set; }
        double Health => 2 * Constitution + 0.5 * Strength;
        double Mana => Intelligence * 3;
    }
}
