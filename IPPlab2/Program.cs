using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IPPlab2.Adapter;
using IPPlab2.Bridge;
using IPPlab2.Decorator;
using IPPlab2.Facade;
using IPPlab2.Flyweight;

namespace IPPlab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------Adapter DEMO:-------");
            Console.WriteLine("Let's make standard cake:");
            Cake cake = new Cake();
            cake.RequestToMakeCake();
            // Create adapter and place a request
            Console.WriteLine("Let's make special cake for our special allergic client:");
            Cake allergicCake = new AdapterCake();
            allergicCake.RequestToMakeCake();
            Console.WriteLine();

            Console.WriteLine("-------Bridge DEMO:-------");
            // make birthday cake
            CakeForEvent cakeForEvent = new BirthdayCake(new CandyGift());
            cakeForEvent.MakeEventCake();
            Console.WriteLine(cakeForEvent.MakeEventCake() +" with gift-> "+ cakeForEvent.AddGiftForEvent());
            // make wedding cake
            cakeForEvent = new WeddingCake(new CandyGift());
            cakeForEvent.Gift = new BisciutGift();
            cakeForEvent.MakeEventCake();
            Console.WriteLine(cakeForEvent.MakeEventCake() +" with gift-> " + cakeForEvent.AddGiftForEvent());
            Console.WriteLine();

            Console.WriteLine("-------Decorator DEMO:-------");
            CreamCake napoleon = new Napoleon();
            napoleon = new MilkCream(napoleon); 
            Console.WriteLine("Name: {0}", napoleon.Name);
            Console.WriteLine("Price: {0}", napoleon.GetCost());

            CreamCake kiev = new Kiev();
            kiev = new ChocoCream(kiev);
            Console.WriteLine("Name: {0}", kiev.Name);
            Console.WriteLine("Price: {0}", kiev.GetCost());

            CreamCake kievSpecial = new Kiev();
            kievSpecial = new MilkCream(kievSpecial);
            kievSpecial = new ChocoCream(kievSpecial);
            Console.WriteLine("Name: {0}", kievSpecial.Name);
            Console.WriteLine("Price: {0}", kievSpecial.GetCost());
            Console.WriteLine();

            Console.WriteLine("-------Facade DEMO:-------");
            Flakes flakes = new Flakes();
            Cream cream = new Cream();
            Pastry pastry = new Pastry();

            PieMakerFacade pieMaker = new PieMakerFacade(cream, flakes, pastry);
            Console.WriteLine("Let's make our cake");
            pieMaker.MakeCake();
            Console.WriteLine("Let's decorate our cake");
            pieMaker.DecorateCake();
            Console.WriteLine();

            Console.WriteLine("-------Flyweight DEMO:-------");
            string[] flowers = { "RedFlower", "WhiteFlower", "WhiteFlower", "WhiteFlower" };
            DecorationFlowerFactory factory = new DecorationFlowerFactory();

            // For each flower use a flyweight object
            foreach (string flower in flowers)
            {
                DecorationFlower decorationFlower = factory.GetDecorationFlowers(flower);
                decorationFlower.DisplaySize();
            }

        }
    }
    
}
