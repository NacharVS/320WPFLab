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
            Console.WriteLine(w.Health);
            Console.WriteLine(w.Magic);
            Console.WriteLine(w.Physic);
            w.Strength *= 2;
            Console.WriteLine(w.Health);
            Console.WriteLine(w.Magic);
            Console.WriteLine(w.Physic);
        }
    }
}
