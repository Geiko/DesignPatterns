using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._3._Products
{
    class CreepMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("hiss ~~~8");
        }
    }
}
