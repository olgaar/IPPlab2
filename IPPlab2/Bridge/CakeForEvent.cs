using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Bridge
{
    public abstract class CakeForEvent
    {
        protected IGift gift;
        public IGift Gift
        {
            set { gift = value; }
           
        }
   
        public CakeForEvent(IGift gift)
        {
            this.gift = gift;
        }
        public virtual string AddGiftForEvent()
        {
            return gift.Build();
        }
        public abstract string MakeEventCake();
    }
}
