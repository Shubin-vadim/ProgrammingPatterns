using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    class Tea : BeverageBase
    {
        public Tea()
        {
            description = "Зеленый чай";
        }
        public override double GetCost()
        {
            return 80;
        }
    }
}
