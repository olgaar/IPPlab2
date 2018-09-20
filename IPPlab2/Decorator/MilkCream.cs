using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Decorator
{
    public class MilkCream: CakeDecorator
    {
        public MilkCream(CreamCake p)
        : base(p.Name + ", with milk cream", p)
        { }

        public override int GetCost()
        {
            return cake.GetCost() + 10;
        }
    }
}
