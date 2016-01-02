using Cars._1._AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cars._2._AbstractProducts;
using Cars._3._Products;

namespace Cars._2._ConcreteFactories
{
    class Porshe911A20_Factory : Porshe911Factory
    {
        public override Engine CreateEngine()
        {
            return new Engine_20();
        }

        public override Gear CreateGear()
        {
            return new Gear_A();
        }
    }
}