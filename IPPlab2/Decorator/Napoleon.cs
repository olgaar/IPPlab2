using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Decorator
{
    public class Napoleon: CreamCake
    {
        public Napoleon() : base("Napoleon cake")
        { }
        public override int GetCost()
        {
            return 100;
        }
    }
}
