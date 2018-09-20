using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Bridge
{
    public class BisciutGift: IGift
    {
        public string Build()
        {
            return "We have a gift for out client: a box of biscuits";
        }
    }
}
