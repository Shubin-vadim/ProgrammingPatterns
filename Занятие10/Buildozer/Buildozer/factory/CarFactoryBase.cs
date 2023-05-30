using Buildozer.builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.factory
{
    abstract class CarFactoryBase
    {
        protected readonly CarBuilderBase carBuilder;

        protected CarFactoryBase(CarBuilderBase carBuilder)
        {
            this.carBuilder = carBuilder;
        }

        public abstract Car Construct();
    }
}
