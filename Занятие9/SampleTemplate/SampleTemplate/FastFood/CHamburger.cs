using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    class CHamburger : CFastFoodBase
    {
        protected override void AddTopings()
        {
            Console.WriteLine("Кетчуп");
        }

        protected override void PrepareMainIngredient()
        {
            Console.WriteLine("Мясо");
        }
    }
}
