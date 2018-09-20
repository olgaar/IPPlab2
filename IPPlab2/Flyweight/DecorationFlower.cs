using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Flyweight
{
    public abstract class DecorationFlower
    {
        protected string name;
        protected int diameter;
        protected int height;
        public void DisplaySize()
        {
            Console.WriteLine("Decoration flower "+name +" diameter= " + this.diameter + " and height= " + this.height);
        }
    }
}
