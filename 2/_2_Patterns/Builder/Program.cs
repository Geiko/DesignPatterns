using Builder._3._Builder;
using Builder._4._ConcreteBuilders;
using Builder.Builder;
using Builder.ConcreteBuilders;
using Builder.Director;
using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Baker baker = new Baker();

            BreadBuilder builder = new RyeBreadBuilder();
            baker.Bake(builder);
            Bread ryeBread = builder.Bread;
            Console.WriteLine(ryeBread.ToString());

            builder = new WheatBreadBuilder();
            baker.Bake(builder);
            Bread wheatBread = builder.Bread;
            Console.WriteLine(wheatBread.ToString());



            Console.WriteLine("--------------\n");



            PizzaBuilder italyBuilder = new MeatPizzaBuilder();
            baker.Bake(italyBuilder);
            Pizza meatPizza = italyBuilder.Pizza;
            Console.WriteLine(meatPizza.ToString());

            italyBuilder = new SeafoodPizzaBuilder();
            baker.Bake(italyBuilder);
            Pizza seafoodPizza = italyBuilder.Pizza;
            Console.WriteLine(seafoodPizza.ToString());

            Console.ReadKey();
        }
    }
}
