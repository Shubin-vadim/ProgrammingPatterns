using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Parts
{
    public class WhitePaint: Paint
    {
        public WhitePaint()
        {
            Console.WriteLine("Белый цвет машины");
        }
    }
}
