using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Flyweight
{
    public class RedFlower: DecorationFlower
    {
        public RedFlower()
        {
            this.name = "RedFlower";
            this.diameter = 10;
            this.height = 10;
        }
    }
}
