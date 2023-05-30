using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad.WashingMachine.SubSystems
{
     class Thermo
    {
       public int GetTemperature()
        {
            return 50;
        }

        public void WarmUp(int degrees)
        {
            Console.WriteLine("Поднять температуру до {0} градусов", degrees);
        }

    }
}
