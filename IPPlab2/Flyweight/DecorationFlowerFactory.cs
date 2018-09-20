using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IPPlab2.Flyweight
{
    public class DecorationFlowerFactory
    {
        private Hashtable flowers = new Hashtable();

        public DecorationFlower GetDecorationFlowers(string key)
        {
            // Uses "lazy initialization"
            DecorationFlower flower = flowers[key] as DecorationFlower;
            if (flower == null)
            {
                switch (key)
                {
                    case "RedFlower": flower = new RedFlower(); break;
                    case "WhiteFlower": flower = new WhiteFlower(); break;
                    
                }
                flowers.Add(key, flower);
            }
            return flower;
        }
    }
}
