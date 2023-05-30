using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Parts
{
    public class BlackPaint: Paint
    {
        public BlackPaint()
        {
            Console.WriteLine("Черный цвет машины");
        }
    }
}
