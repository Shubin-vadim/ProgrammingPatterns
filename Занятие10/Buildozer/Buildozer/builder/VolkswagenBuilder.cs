using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buildozer.builder
{
    class VolkswagenBuilder : CarBuilderBase
    {
        public VolkswagenBuilder(): base()
        {
        }

        public override void BuildEngine()
        {
            car.Engine = "1.8 TSI";
        }

        public override void BuildFrame()
        {
            car.Frame = "VW 456FGH456GHJ";
        }

        public override void BuildLuxury()
        {
            car.Luxury = "R-style";
        }

        public override void BuildMultimedia()
        {
            car.Muitimedia = "SpaceX";
        }

        public override void BuildSafety()
        {
            car.Safety = "OpenAI";
        }

        public override void BuildWheels()
        {
            car.Wheels = "NeuralLink";
        }
    }
}
