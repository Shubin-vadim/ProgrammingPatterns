using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Beverage
{
    public abstract class BeverageBase
    {
        protected string description = "";
        public string GetDescription()
        {
            return description;
        }

        public abstract double GetCost();
    }
}
