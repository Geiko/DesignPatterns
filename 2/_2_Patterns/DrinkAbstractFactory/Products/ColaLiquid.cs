using DrinkAbstractFactory._2.AbstractProdacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory.Products
{
    class ColaLiquid : Liquid
    {
        public override void HasTaste()
        {
            Console.WriteLine("Taste :   Vanilla, Oil of Cloves");
        }
    }
}

