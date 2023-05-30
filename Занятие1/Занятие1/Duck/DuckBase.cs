using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Занятие1.Fly;
using Занятие1.Quack;

namespace Занятие1.Duck
{
    public abstract class DuckBase
    {
      public iFly flyBehavior;
      public iQuack quackBehavior;
        protected DuckBase()
        {
            flyBehavior = new SimpleFly();
            quackBehavior = new SimpleQuack();
        }

        public abstract void Display();
        public abstract void Quack();

    }
}
