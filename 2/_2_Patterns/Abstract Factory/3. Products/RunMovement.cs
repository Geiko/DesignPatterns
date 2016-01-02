using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("top-top-top..");
        }
    }
}
