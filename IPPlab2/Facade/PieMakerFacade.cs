using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Facade
{
    public class PieMakerFacade
    {
        Cream cream;
        Flakes flakes;
        Pastry pastry;

        public PieMakerFacade(Cream cream, Flakes flakes, Pastry pastry)
        {
            this.cream = cream;
            this.flakes = flakes;
            this.pastry = pastry;
        }
        public void MakeCake()
        {
            pastry.MakePastry();
            cream.MakeCream();
            pastry.AddPastry();
            cream.AddCream();
            pastry.AddPastry();
            cream.AddCream();

        }
        public void DecorateCake()
        {
            flakes.AddFlakes();
        }
    }
}
