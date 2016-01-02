using Cars._2._AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars._3._Products
{
    class Gear_A : Gear
    {
        public override void HasStick()
        {
            Console.WriteLine("Gear - Auto \n");
        }
    }
}
