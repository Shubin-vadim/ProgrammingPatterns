using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Занятие1.Fly;
using Занятие1.Quack;

namespace Занятие1.Duck
{
    public class DuckExotic: DuckBase
    {

        public DuckExotic()
        {
            flyBehavior = new NoFly();
            quackBehavior = new NoQuack();
        }
        public override void Display()
        {
            Console.WriteLine("This DuckExotic");
        }

        public override void Quack()
        {
    ///        base.Quack();
            Console.WriteLine("AAAAAAAAAAAAAAAAAA");
        }

    }
}
