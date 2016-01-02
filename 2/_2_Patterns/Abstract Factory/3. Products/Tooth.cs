using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._3._Products
{
    class Tooth : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("bite   -----8=");
        }
    }
}
