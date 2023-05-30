using System;

namespace State
{
    class Programm
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Drive();
            car.TurnKey();
            car.FillTank();
            car.TurnKey();
            car.TurnKey();
            car.TurnKey();
            car.Drive();
            car.Stop();
            car.Drive();
            car.Drive();
            car.Drive();
            car.Drive();
            car.Drive();
            car.Drive();
        }
    }
}