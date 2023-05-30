using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand.ControllerSystems
{
    class CTeapot
    {

        public CSystemState State { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Чайник включен");
            State = CSystemState.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Чайник выключен");
            State = CSystemState.Off;
        }

    }
}
