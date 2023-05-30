using AbstractFactory.Facility;
using AbstractFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PartsFactory
{
    public abstract class CarPartsFactory
    {
        public abstract Engine CreateEngine();
        public abstract Paint CreatePaint();
        public abstract Wheels CreateWheels();

       
    }
}
