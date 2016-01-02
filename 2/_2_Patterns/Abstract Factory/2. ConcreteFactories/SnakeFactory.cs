using Abstract_Factory._3._Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory._2._ConcreteFactories
{
    class SnakeFactory :HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new CreepMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Tooth();
        }
    }
}
