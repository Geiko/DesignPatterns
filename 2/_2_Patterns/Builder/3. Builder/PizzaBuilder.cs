using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._3._Builder
{
    abstract class PizzaBuilder
    {
        public Pizza Pizza { get; private set; }

        public PizzaBuilder()
        {
            Pizza = new Pizza();
        }

        public abstract void SetWheatFlour();
        public abstract void SetRyeFlour();
        public abstract void SetSalt();
        public abstract void SetAdditives();

        public abstract void SetCheese();
        public abstract void SetMeat();
        public abstract void SetMushroom();
        public abstract void SetSeafood();
        public abstract void SetTomato();
    }
}
