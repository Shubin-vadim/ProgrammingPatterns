using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
    class DrivingState : IState
    {

        private readonly Car car;

        public DrivingState(Car car)
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
                Console.WriteLine("Продолжение движения.");
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
            Console.WriteLine("Предупреждение: Невозможно во время движения");
            return false;
        }

        public void Stop()
        {
            Console.WriteLine("Остановка движения");
            car.ChangeState(car.EngineStarted);
        }

        public void TurnKey()
        {
            Console.WriteLine("Предупреждение: Невозможно во время движения");
        }
    }
}
