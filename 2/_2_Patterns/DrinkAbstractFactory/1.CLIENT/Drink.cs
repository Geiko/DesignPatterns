using DrinkAbstractFactory._1._ABSTRACT_FACTORY;
using DrinkAbstractFactory._2.AbstractProdacts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory._1.CLIENT
{
    class Drink
    {
        private Bottle bottle;
        private Liquid liquid;

        public Drink(DrinkFactory factory)
        {
            bottle = factory.CreateBottle();
            liquid = factory.CreateLiquid();
        }

        public void DrinkBottle()
        {
            bottle.HasLabel();
        }

        public void DrinkLiquid()
        {
            liquid.HasTaste();
        }
    }
}
