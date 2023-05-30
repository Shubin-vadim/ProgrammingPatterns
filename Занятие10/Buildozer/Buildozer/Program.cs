using Buildozer.builder;
using Buildozer.factory;
using System;

namespace Buildozer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cheap Volkswagen");
            CarFactoryBase constructor = new ChearpCarFactory(new VolkswagenBuilder());
            var car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Volkswagen");
            constructor = new LuxuryCarFactory(new VolkswagenBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);


            Console.WriteLine("Cheap Audi");
             constructor = new ChearpCarFactory(new AudiBuilder());
             car = constructor.Construct();
            Console.WriteLine(car);

            Console.WriteLine("Luxury Audi");
            constructor = new LuxuryCarFactory(new AudiBuilder());
            car = constructor.Construct();
            Console.WriteLine(car);
        }
    }
}