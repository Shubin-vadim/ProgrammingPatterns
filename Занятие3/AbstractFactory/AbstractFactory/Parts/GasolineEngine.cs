using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Parts
{
    public  class GasolineEngine: Engine
    {
        public GasolineEngine()
        {
            Console.WriteLine("Газовый двигатель");
        }
    }
}
