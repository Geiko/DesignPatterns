using DrinkAbstractFactory._2.AbstractProdacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory.Products
{
    class SpriteBottle : Bottle
    {
        public override void HasLabel()
        {
            Console.WriteLine("Bottle:   S p r i t e");
        }
    }
}
