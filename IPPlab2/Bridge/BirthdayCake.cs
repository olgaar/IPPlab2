using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Bridge
{
    public class BirthdayCake: CakeForEvent
    {
        public BirthdayCake(IGift gift) : base(gift)
        {
        }
        public override string MakeEventCake()
        {
            return "Make writing HAPPY BIRTHDAY for birthday cake";
        }
    }
}
