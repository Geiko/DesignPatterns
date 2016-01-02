using DrinkAbstractFactory._1.CLIENT;
using DrinkAbstractFactory._2.ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkAbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Drink cola = new Drink(new ColaFactory());
            cola.DrinkBottle();
            cola.DrinkLiquid();
            Console.WriteLine();


            Drink fanta = new Drink(new FantaFactory());
            fanta.DrinkBottle();
            fanta.DrinkLiquid();
            Console.WriteLine();


            Drink sprite = new Drink(new SpriteFactory());
            sprite.DrinkBottle();
            sprite.DrinkLiquid();
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
