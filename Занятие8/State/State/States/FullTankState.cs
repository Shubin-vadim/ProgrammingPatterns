using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class FullTankState : IState
    {
        private readonly Car car;

        public FullTankState(Car car)
        {
            this.car = car;
        }

        public bool Drive()
        {
            Console.WriteLine("Предупреждение: необходимо запустить двигатель!");
            return false;
        }

        public bool FillTank()
        {
            Console.WriteLine("Предупреждение: высокий уровень топлива!");
            return false;
        }

        public void Stop()
        {
            Console.WriteLine("Предупреждение: машина уже в режиме парковки!");
        }

        public void TurnKey()
        {
            Console.WriteLine("Запуск двигателя");
            car.ChangeState(car.EngineStarted);
        }
    }
}
