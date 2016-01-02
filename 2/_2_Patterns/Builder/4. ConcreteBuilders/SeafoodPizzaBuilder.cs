using Builder._3._Builder;
using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder._4._ConcreteBuilders
{
    class SeafoodPizzaBuilder : PizzaBuilder
    {
        public override void SetAdditives()
        {
            this.Pizza.Additives = new Additives { Name = "drogggi, vanilla" };
        }

        public override void SetRyeFlour()
        {

        }

        public override void SetSalt()
        {
            this.Pizza.Salt = new Salt();
        }

        public override void SetWheatFlour()
        {
            this.Pizza.WheatFlour = new Flour { Sort = "Highest sort" };
        }


        public override void SetCheese()
        {
            this.Pizza.Cheese = new Cheese { Name="Parmesan" };
        }

        public override void SetMeat()
        {  
        
        }

        public override void SetMushroom()
        {
            
        }

        public override void SetSeafood() 
        {
            this.Pizza.Seafood = new Seafood { Name = "Shrimps, Octopus, Oysters" };
        }

        public override void SetTomato()
        {

        }      
    }
}
