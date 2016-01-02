using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Hero
    {
        private Weapon weapon;
        private Movement movement;

        public Hero(HeroFactory factory)
        {
            weapon = factory.CreateWeapon();
            movement = factory.CreateMovement();
        }

        public void HeroMove()
        {
            movement.Move();
        }

        public void HeroHit()
        {
            weapon.Hit();
        }
    }
}
