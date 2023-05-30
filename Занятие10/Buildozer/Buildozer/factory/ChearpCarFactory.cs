using Buildozer.builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.factory
{
    class ChearpCarFactory : CarFactoryBase
    {
        public ChearpCarFactory(CarBuilderBase carBuilder) : base(carBuilder)
        {
        }

        public override Car Construct()
        {
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();
            carBuilder.BuildSafety();
            return carBuilder.GetCar();
        }
    }
}
