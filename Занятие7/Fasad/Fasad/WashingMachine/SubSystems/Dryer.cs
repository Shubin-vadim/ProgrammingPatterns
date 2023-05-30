using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad.WashingMachine.SubSystems
{
     class Dryer
    {
        public void Dry(int seconds, int intensity)
        {
            Console.WriteLine("Отжим {0} секунд с интенсивностью {1}", seconds, intensity);
        }
    }
}
