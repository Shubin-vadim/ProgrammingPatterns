using System;
using System.Collections.Generic;
using Занятие1.Duck;

namespace Занятие1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<DuckBase> ducks = new List<DuckBase>();
            ducks.Add(new DuckExotic());
            ducks.Add(new DuckSimple());
            foreach (var duck in ducks)
            {
                duck.Display();
                duck.flyBehavior.Fly();
                duck.quackBehavior.Quack();
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}