using SampleAdapter.HomeCats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleAdapter.Adapters
{
    class HomeCatAdapter : IHomeCat
    {
        private IWildCat cat;

        public HomeCatAdapter(IWildCat cat)
        {
            this.cat = cat;
        }

        public string Name { get => cat.Breed; set { } }

        public void Meow()
        {
            cat.Grow();
        }

        public void Scratch()
        {
           cat.Scratch();
        }
  
    }
}
