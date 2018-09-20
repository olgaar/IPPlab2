using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Decorator
{
    public class ChocoCream: CakeDecorator
    {
        public ChocoCream(CreamCake p)
       : base(p.Name + ", with choco cream", p)
        { }

        public override int GetCost()
        {
            return cake.GetCost() + 20;
        }
    }
}
