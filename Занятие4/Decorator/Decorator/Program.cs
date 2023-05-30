using Decorator.Beverage;
using Decorator.Condiments;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            BeverageBase espresso = new Expresso();

            print(espresso);
            BeverageBase capuchino = new Sugar(new Milk(espresso));
            print(capuchino);
        }

        private static void print(BeverageBase beverage)
        {
            Console.WriteLine("Напиток {0}, Цена {1}", beverage.GetDescription(), beverage.GetCost());
        }
    }
}