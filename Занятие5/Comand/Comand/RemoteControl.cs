using Comand.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comand
{
    public class RemoteControl
    {
        private Dictionary<int, ICommand> comms;

        public RemoteControl(Dictionary<int, ICommand> comms)
        {
            this.comms = new Dictionary<int, ICommand>();
        }

        public RemoteControl()
        {
        }

        public void SetCommandForButton(int buttonId, ICommand cmd)
        {
            comms[buttonId] = cmd;
        }

        public void PushButton(int buttonId)
        {
            if (comms.ContainsKey(buttonId))
            {
                comms[buttonId].Execute();
            }
        }


        public void UndoButton(int buttonId)
        {
            if (comms.ContainsKey(buttonId))
            {
                comms[buttonId].Undo();
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var buttonId in comms.Keys)
            {
                sb.AppendFormat("{0} \t- {1}\n", buttonId, comms[buttonId]);
            }

            sb.Append("проч. \t-Выход");
            return sb.ToString();
        }

    }
}
