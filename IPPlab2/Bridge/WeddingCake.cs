using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Bridge
{
    public class WeddingCake :CakeForEvent
    {
        public WeddingCake(IGift gift) : base(gift)
        {
        }
        public override string MakeEventCake()
        {
            return "Make writing HAPPY WEDDING for wedding cake";
        }
    }
}
