using AbstractFactory.PartsFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Cars
{
    public class Golf : Car
    {

        private CarPartsFactory partsFactory;
        public Golf(CarPartsFactory partsFactory)
        {
            Name = "Golf";
            Body = "Hatchback";
            this.partsFactory = partsFactory; 
        }

        public override void Configure()
        {
            Console.WriteLine("Конфигурация {0}", Name);
            Console.WriteLine("Кузов {0}", Body);

            Engine = partsFactory.CreateEngine();
            PaintColor = partsFactory.CreatePaint();
            Wheels = partsFactory.CreateWheels();
        }
    }
}
