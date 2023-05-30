using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Parts
{
    public  class DiselEngine: Engine
    {
        public DiselEngine()
        {
            Console.WriteLine("Дизельный двигатель");
        }
    }
}
