using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие1.Quack
{
    public class SimpleQuack : iQuack
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
