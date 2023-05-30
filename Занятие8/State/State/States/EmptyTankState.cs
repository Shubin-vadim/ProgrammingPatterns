using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
     class EmptyTankState : IState

    {
        private readonly Car car;

        public EmptyTankState(Car car)
        {
            this.car = car;
        }

        public bool Drive()
        {
            Console.WriteLine("Предупреждение: низкий уровень топлива!");
            return false;
        }

        public bool FillTank()
        {
            Console.WriteLine("Высокий уровень топлива!");
            car.ChangeState(car.FullTank);
            return true;
        }

        public void Stop()
        {
            Console.WriteLine("какой-то текст");
        }

        public void TurnKey()
        {
            Console.WriteLine("Предупреждение: низкий уровень топлива!");
        }
    }
}
