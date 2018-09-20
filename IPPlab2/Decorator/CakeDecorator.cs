using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Decorator
{
    public abstract class CakeDecorator: CreamCake
    {
        protected CreamCake cake;
        public CakeDecorator(string n, CreamCake cake) : base(n)
        {
            this.cake = cake;
        }
    }
}
