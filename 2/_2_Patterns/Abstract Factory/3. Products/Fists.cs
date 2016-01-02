using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._3._Products
{
    class Fists : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("kick ----o");
        }
    }
}
