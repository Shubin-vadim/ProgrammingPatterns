using AbstractFactory.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.PartsFactory
{
    internal class DeutschCarPartsFactory : CarPartsFactory
    {
        public override Engine CreateEngine()
        {
            return new DiselEngine();
        }

        public override Paint CreatePaint()
        {
            return new WhitePaint();
        }

        public override Wheels CreateWheels()
        {
            return new _17Wheels();
        }
    }
}
