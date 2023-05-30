using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.HomeCats
{
     interface IHomeCat
    {
        string Name { get; set; }
       public void Meow();
        public void Scratch();
    }
}
