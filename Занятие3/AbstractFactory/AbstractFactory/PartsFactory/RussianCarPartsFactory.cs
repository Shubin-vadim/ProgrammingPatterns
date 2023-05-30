using AbstractFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PartsFactory
{
    public class RussianCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new GasolineEngine();
        }

        public override Paint CreatePaint()
        {
            return new BlackPaint();
        }

        public override Wheels CreateWheels()
        {
            return new _16Wheels();
        }
    }
}
