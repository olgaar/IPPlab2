using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Adapter
{
    public class AdapterCake : Cake
    {
        private AdapteeCake adaptee = new AdapteeCake();

        public override void RequestToMakeCake()
        {
            // Possibly do some other work
            // and then call SpecificRequest
            adaptee.SpecificRequestToMakeCake();
        }
    }
}
