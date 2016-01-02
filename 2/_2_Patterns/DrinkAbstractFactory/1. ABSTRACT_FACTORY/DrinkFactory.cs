using DrinkAbstractFactory._2.AbstractProdacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory._1._ABSTRACT_FACTORY
{
    abstract class DrinkFactory
    {
        public abstract Bottle CreateBottle();
        public abstract Liquid CreateLiquid();
    }
}
