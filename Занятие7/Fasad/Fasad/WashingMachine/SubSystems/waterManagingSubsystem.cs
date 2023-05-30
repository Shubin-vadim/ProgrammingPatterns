using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fasad.WashingMachine.SubSystems
{
     class waterManagingSubsystem
    {

        public void FillWater(int litres)
        {
            Console.WriteLine("Добавлено {0} литров воды", litres);
        }

        public void EmptyWater()
        {
            Console.WriteLine("Барабан пуст");
        }

    }
}
