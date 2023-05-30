using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.HomeCats
{
    internal class YardCat : IHomeCat
    {
        public string Name { get ; set ; }
        public void Meow()
        {
            Console.WriteLine("Мяукает");
        }

        public void Scratch()
        {
            Console.WriteLine("Царапается");
        }
    }
}
