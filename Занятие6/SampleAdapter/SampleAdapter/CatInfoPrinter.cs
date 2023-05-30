using SampleAdapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter
{
     class CatInfoPrinter
    {
        public static void PrintCatInfo(IHomeCat cat)
        {
            Console.WriteLine("Кошачье досье");
            Console.WriteLine(string.Format("Имя {0}", cat.Name));
            Console.WriteLine("Вызов Meow");
            cat.Meow();
            Console.WriteLine("Вызов Scratch");
            cat.Scratch();
            Console.WriteLine("*************************************************");
        }
    }
}
