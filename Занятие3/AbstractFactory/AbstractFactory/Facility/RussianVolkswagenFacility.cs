using AbstractFactory.Cars;
using AbstractFactory.PartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Facility
{
    class RussianVolkswagenFacility : VolkswagenFacility
    {
        protected override Car CreateCar(string type)
        {
            CarPartsFactory carPartsFactory = new RussianCarPartsFactory();
            if (type == "Golf")
            {
                return new Golf(carPartsFactory);
            }else if (type == "Passat")
            {
                return new Passat(carPartsFactory);
            }
            return null;
        }
    }
}
