using Builder._3._Builder;
using Builder.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Director
{
    class Baker
    {
        public void Bake(BreadBuilder breadBuilder)
        {
            breadBuilder.SetWheatFlour();
            breadBuilder.SetRyeFlour();
            breadBuilder.SetSalt();
            breadBuilder.SetAdditives();
        }

        public void Bake(PizzaBuilder pizzaBuilder)
        {
            pizzaBuilder.SetCheese();
            pizzaBuilder.SetMeat();
            pizzaBuilder.SetMushroom();
            pizzaBuilder.SetSeafood();
            pizzaBuilder.SetTomato();
        }
    }
}
