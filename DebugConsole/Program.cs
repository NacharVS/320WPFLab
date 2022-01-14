using System;
using Core;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Archer d = new Archer("bob", 50, 50, 50, 50);
            d.SetStrength(60);
            Console.WriteLine(d.Strength);
            d.SetStrength(20);
            Console.WriteLine(d.Strength);
        }
    }
}
