using SampleTemplate.FastFood;
using System;

namespace SampleTemplate
{
    class Program
    {
        static void Main(string[] args)
        {
            var hamburger = new CHamburger();
            var hotdog = new CHotDogcs();

            Console.WriteLine("\nHamburger");
            hamburger.Prepare();
            Console.WriteLine("\nHotDog");
            hotdog.Prepare();
        }
    }
}