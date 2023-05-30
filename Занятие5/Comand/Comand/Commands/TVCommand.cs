using Comand.ControllerSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand.Commands
{
    public class TVCommand : ICommand
    {
        private CTv tv;

        public TVCommand(CTv tv)
        {
            this.tv = tv;
        }

        public void Execute()
        {
            if (tv.State == CSystemState.Off)
            {
                tv.TurnOn();
            }
            else
            {
                Console.WriteLine("Телевизор и так включен");
            }
         
        }

        public void Undo()
        {
            if (tv.State == CSystemState.On)
            {
                tv.TurnOff();
            }
            else
            {
                Console.WriteLine("Телевизор и так выключен");
            }
        }

        public override string ToString()
        {
            return "включить телевизор";
        }
    }
}
