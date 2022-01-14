using System;
using BaseEmptyApp.Classes;


namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            Warrior f = new Warrior();
            Console.WriteLine(f.PAttack);
            Console.WriteLine("End");

        }
    }
}
