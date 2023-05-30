using Comand.ControllerSystems;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand.Commands
{
    class TeapotCommand : ICommand
    {
        private CTeapot teapot;

        public TeapotCommand(CTeapot teapot)
        {
            this.teapot = teapot;
        }

        public void Execute()
        {
            if (teapot.State == CSystemState.Off)
            {
                teapot.TurnOn();
            }
            else
            {
                Console.WriteLine("чайник и так включен");
            }

        }

        public void Undo()
        {
            if (teapot.State == CSystemState.On)
            {
                teapot.TurnOff();
            }
            else
            {
                Console.WriteLine("чайник и так выключен");
            }
        }

        public override string ToString()
        {
            return "включить чайник";
        }
    }
}
