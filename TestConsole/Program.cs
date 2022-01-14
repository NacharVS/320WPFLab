using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core;

namespace TestConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Warrior w = new Warrior();
            Console.WriteLine(w.Strength);
            w.Strength = 10;
            Console.WriteLine(w.Strength);
        }
    }
}
