using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad.WashingMachine.SubSystems
{
     class Engine
    {
        public void Rotate()
        {
            Console.WriteLine("Запуск барабана");
        }

        public void Stop()
        {
            Console.WriteLine("Остановка барабана");
        }
    }
}
