using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand.ControllerSystems
{
    public class CTv
    {
        public CSystemState State { get; set; }
        public void TurnOn()
        {
            Console.WriteLine("Телевизор включен");
            State = CSystemState.On;
        }

        public void TurnOff()
        {
            Console.WriteLine("Телевизор выключен");
            State = CSystemState.Off;
        }
    }
}
