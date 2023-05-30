using Buildozer.builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.factory
{
    class LuxuryCarFactory : CarFactoryBase
    {
        public LuxuryCarFactory(CarBuilderBase carBuilder) : base(carBuilder)
        {
        }

        public override Car Construct()
        {
            carBuilder.BuildFrame();
            carBuilder.BuildEngine();
            carBuilder.BuildWheels();
            carBuilder.BuildSafety();
            carBuilder.BuildMultimedia();
            carBuilder.BuildLuxury();

            return carBuilder.GetCar();
        }
    }
}
