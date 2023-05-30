using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.HomeCats
{
     interface IWildCat
    {
        string Breed { get; }
        void Grow();
        void Scratch();
    }
}
