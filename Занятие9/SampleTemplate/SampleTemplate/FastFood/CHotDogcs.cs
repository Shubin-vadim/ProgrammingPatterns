using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    class CHotDogcs : CFastFoodBase
    {
        protected override void AddTopings()
        {
            Console.WriteLine("Горчица");
        }

        protected override void PrepareMainIngredient()
        {
            Console.WriteLine("Сосиска");
        }

        protected override bool CustomerWantsTopings()
        {
        /*    var baseValue =  base.CustomerWantsTopings();
            return false;*/
        Console.WriteLine("Вам нужен соус? (y/n)");
        var userInput = Console.ReadLine();
            return userInput.ToLower() == "yes" || userInput.ToLower() == "y";
        }

    }
}
