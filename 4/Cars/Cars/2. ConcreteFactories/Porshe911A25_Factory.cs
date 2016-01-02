using Cars._1._AbstractFactory;
using Cars._2._AbstractProducts;
using Cars._3._Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars._2._ConcreteFactories
{
    class Porshe911A25_Factory : Porshe911Factory
    {
        public override Engine CreateEngine()
        {
            return new Engine_25();
        }

        public override Gear CreateGear()
        {
            return new Gear_A();
        }
    }
}