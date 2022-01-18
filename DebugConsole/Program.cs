using System;
using Core;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var d = new Mage("bob", 15, 30, 15, 20);
            Console.WriteLine(d.Strength);
            d.RemoveStrength();
            Console.WriteLine(d.Strength);

        }
    }
}
