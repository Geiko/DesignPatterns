using DrinkAbstractFactory._1._ABSTRACT_FACTORY;
using DrinkAbstractFactory._2.AbstractProdacts;
using DrinkAbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory._2.ConcreteFactories
{
    class ColaFactory : DrinkFactory
    {
        public override Bottle CreateBottle()
        {
            return new ColaBottle();
        }

        public override Liquid CreateLiquid()
        {
            return new ColaLiquid();
        }
    }
}
