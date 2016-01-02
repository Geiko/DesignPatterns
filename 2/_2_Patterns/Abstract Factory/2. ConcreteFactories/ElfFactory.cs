using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class ElfFactory : HeroFactory
    {
        public override Movement CreateMovement()
        {
            return new FlyMovement();
        }

        public override Weapon CreateWeapon()
        {
            return new Bow();
        }
    }
}
