using AbstractFactory.Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Facility
{
    abstract class VolkswagenFacility
    {

        public Car GetCar(string type)
        {
            Car car = CreateCar(type);
            if (car != null)
            {
                car.Configure();
                car.AssembleBody();
                car.InstallEngine();
                car.InstallPaint();
                car.InstallWheels();
            }
            return car;
        }
        protected abstract Car CreateCar(string type);
    }
}
