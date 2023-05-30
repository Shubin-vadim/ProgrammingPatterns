using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.builder
{
    class AudiBuilder : CarBuilderBase
    {
        public AudiBuilder() : base()
        {
        }

        public override void BuildEngine()
        {
            car.Engine = "2.0 TSFI";
        }

        public override void BuildFrame()
        {
            car.Frame = "VX 213FGH456GHJ";
        }

        public override void BuildLuxury()
        {
            car.Luxury = "P-style";
        }

        public override void BuildMultimedia()
        {
            car.Muitimedia = "BlueOrigin";
        }

        public override void BuildSafety()
        {
            car.Safety = "something info";
        }

        public override void BuildWheels()
        {
            car.Wheels = "wheeelll audi";
        }
    }
}
