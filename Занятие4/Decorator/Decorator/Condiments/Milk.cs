using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Milk : CondimentsDecorator
    { 
        private static double MILK_COST = 20;
        private static string MILK_DESCRIPTION = " + МОЛОКО";
        BeverageBase beverageBase;

        public Milk(BeverageBase beverage)
        {
            this.beverageBase = beverage;
            description = beverage.GetDescription() + MILK_DESCRIPTION;
        }

        public override double GetCost()
        {
            return this.beverageBase.GetCost() + MILK_COST;
        }
    }
}
