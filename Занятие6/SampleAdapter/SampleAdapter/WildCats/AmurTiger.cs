using SampleAdapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.WildCats
{
    class AmurTiger : IWildCat
    {
        public string Breed => "Амурский тигр";

        public void Grow()
        {
            Console.WriteLine("Рычит");
        }

        public void Scratch()
        {
            Console.WriteLine("Сильно царапается");
        }
    }
}
