using System;
using Core;

namespace DebugConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Warrior d = new Warrior("bob", 50, 50, 50, 50);
            d.SetStrength(60);
            Console.WriteLine(d.Strength);
            d.SetStrength(500);
            Console.WriteLine(d.Strength);
        }
    }
}
