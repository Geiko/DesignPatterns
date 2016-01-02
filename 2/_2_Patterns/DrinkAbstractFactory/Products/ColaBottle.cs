using DrinkAbstractFactory._2.AbstractProdacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory.Products
{
    class ColaBottle : Bottle
    {
        public override void HasLabel()
        {
            Console.WriteLine("Bottle:   Coca Cola");
        }
    }
}
