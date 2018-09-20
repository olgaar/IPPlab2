using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Adapter
{
    public class Cake
    {
        public virtual void RequestToMakeCake()
        {
            Console.WriteLine("Make standard cake");
        }
    }
}
