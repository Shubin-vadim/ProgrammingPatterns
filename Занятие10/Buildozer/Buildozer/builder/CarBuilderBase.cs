using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.builder
{
  abstract  class CarBuilderBase
    {
        public Car car;
        public CarBuilderBase()
        {
            car = new Car();
        }

        public Car GetCar()
        {
            return car;
        }

        public abstract void BuildEngine();
        public abstract void BuildFrame();
        public abstract void BuildWheels();
        public abstract void BuildLuxury();
        public abstract void BuildMultimedia();
        public abstract void BuildSafety();
    }
}
