using Cars._2._AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars._1._AbstractFactory
{
    abstract class Porshe911Factory
    {
        public abstract Engine CreateEngine();
        public abstract Gear CreateGear();
    }
}