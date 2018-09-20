using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Flyweight
{
    public class WhiteFlower: DecorationFlower
    {
        public WhiteFlower()
        {
            this.name = "WhiteFlower";
            this.diameter = 5;
            this.height = 3;
        }
    }
}
