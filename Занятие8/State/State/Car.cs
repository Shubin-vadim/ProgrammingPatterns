using State.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
    class Car
    {

        public Car() {
            EmptyTank = new EmptyTankState(this);
            EngineStarted = new EngineStartedState(this);
            FullTank = new FullTankState(this);
            Driving = new DrivingState(this);
            Gasoline = 0;
            state = EmptyTank;
        }

        private IState state;
        public EmptyTankState EmptyTank { get; private set; }
        public EngineStartedState EngineStarted { get; private set; }
        public FullTankState FullTank { get; private set; }
        public DrivingState Driving { get; private set; }
        public int Gasoline { get; private set; }


        public void FillTank()
        {
            if(state.FillTank())
                Gasoline = 70;
        }

        public void TurnKey()
        {
            state.TurnKey();
        }

        public void Drive()
        {
            state.Drive();
            Gasoline -= 20;

        }

        public void Stop()
        {
            state.Stop();
        }

        public void ChangeState(IState nextState)
        {
            this.state = nextState;
        }
    }
}
