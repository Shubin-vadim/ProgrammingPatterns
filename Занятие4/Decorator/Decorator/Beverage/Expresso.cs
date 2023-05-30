using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class Expresso : BeverageBase
    {
        public Expresso()
        {
            description = "Маленькая порция кофе";
        }

        public override double GetCost()
        {
            return 90;
        }
    }
}
