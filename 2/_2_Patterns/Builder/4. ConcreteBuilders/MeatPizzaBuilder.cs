using Builder._3._Builder;
using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._4._ConcreteBuilders
{
    class MeatPizzaBuilder : PizzaBuilder
    {
        public override void SetAdditives()
        {

        }

        public override void SetRyeFlour()
        {
            this.Pizza.RyeFlour = new Flour { Sort = "1st sort" };
        }

        public override void SetSalt()
        {
            this.Pizza.Salt = new Salt();
        }

        public override void SetWheatFlour()
        {

        }


        public override void SetCheese()
        {
            this.Pizza.Cheese = new Cheese { Name="Parmesan" };
        }

        public override void SetMeat()
        {
            this.Pizza.Meat = new Meat { Name = "Hamon, Baloney" };
        }

        public override void SetMushroom()
        {
            this.Pizza.Mushroom = new Mushroom { Name = "Сhampignon" };
        }

        public override void SetSeafood()
        { 
        
        }

        public override void SetTomato()
        {
            this.Pizza.Tomato = new Tomato();
        }
    }
}
