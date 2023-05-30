using Decorator.Beverage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Condiments
{
    class Sugar : CondimentsDecorator

    {
        private static double SUGAR_COST = 0;
        private static string MILK_DESCRIPTION = " + САХАР";
        BeverageBase beverageBase;

        public Sugar(BeverageBase beverageBase)
        {
            this.beverageBase = beverageBase;
            description = beverageBase.GetDescription() + MILK_DESCRIPTION;

        }

        public override double GetCost()
        {
           return this.beverageBase.GetCost() + SUGAR_COST;
        }
    }
}
