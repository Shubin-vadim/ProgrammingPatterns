using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
     interface IState
    {
        bool FillTank();
        void TurnKey();
        bool Drive();
        void Stop();
    }
}
