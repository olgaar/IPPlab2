using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Decorator
{
    public class Kiev: CreamCake
    {
        public Kiev() : base("Kiev cake")
        { }
        public override int GetCost()
        {
            return 120;
        }
    }
}
