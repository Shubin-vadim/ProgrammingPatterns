using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class EngineStartedState : IState
    {

        private readonly Car car;

        public EngineStartedState(Car car)
        {
            this.car = car;
        }

        public bool Drive()
        {
           return TryDrive();  
        }

        private bool TryDrive()
        {
            bool rezult = true;
            if (car.Gasoline > 0)
            {
                Console.WriteLine("Начало движения.");
                car.ChangeState(car.Driving);
            }
            else
            {
                Console.WriteLine("Предупреждение: низкий уровень топлива!");
                car.ChangeState(car.EmptyTank);
                rezult = false;
            }
            return rezult;
        }
        public bool FillTank()
        {
            Console.WriteLine("Предупреждение: Невозможно во время работы двигателя!");
            return false;
        }

        public void Stop()
        {
            Console.WriteLine("Предупреждение: машина уже в режиме парковки!");
        }

        public void TurnKey()
        {
            Console.WriteLine("Выключение двигателяю");
            car.ChangeState(car.FullTank);
        }
    }
}
