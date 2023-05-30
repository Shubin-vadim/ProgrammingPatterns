using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Занятие1.Fly
{
    public class NoFly:iFly
    {
        public void Fly()
        {
            Console.WriteLine("Unflyable");
        }
    }
}
