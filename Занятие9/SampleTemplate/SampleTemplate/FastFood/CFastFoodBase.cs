using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleTemplate.FastFood
{
    abstract class CFastFoodBase
    {
        public void Prepare()
        {
            RoastBread();
            PrepareMainIngredient();
            PutVegetables();

            if (CustomerWantsTopings())
            {
                AddTopings();
            }
        }

        protected abstract void AddTopings();
        protected abstract void PrepareMainIngredient();
        protected virtual bool CustomerWantsTopings()
        {
            return true;
        }

        private void PutVegetables()
        {
            Console.WriteLine("Овощи");
        }

        private void RoastBread()
        {
            Console.WriteLine("Хлеб");
        }
    }
}
