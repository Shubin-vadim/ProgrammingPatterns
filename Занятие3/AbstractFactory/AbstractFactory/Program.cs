using AbstractFactory.Facility;
using System;

namespace AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world!");
        VolkswagenFacility facility = new DeutschVolkswagenFacility();

        facility.GetCar("Golf");
        Console.WriteLine();

        facility.GetCar("Passat");
        Console.WriteLine();


        facility = new RussianVolkswagenFacility();

        facility.GetCar("Golf");
        Console.WriteLine();

        facility.GetCar("Passat");
        Console.WriteLine();

    }
}