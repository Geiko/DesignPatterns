using Abstract_Factory._2._1._ConcreteFactories;
using Abstract_Factory._2._ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Hero elf = new Hero(new ElfFactory());
            elf.HeroHit();
            elf.HeroMove();
            Console.WriteLine();

            Hero warrior = new Hero(new WarriorFactory());
            warrior.HeroMove();
            warrior.HeroHit();
            Console.WriteLine();

            Console.WriteLine("----------------\n");

            Hero boxer = new Hero(new BoxerFactory());
            boxer.HeroMove();
            boxer.HeroHit();
            boxer.HeroHit();
            boxer.HeroMove();
            Console.WriteLine();

            Hero snake = new Hero(new SnakeFactory());
            snake.HeroMove();
            snake.HeroHit();

            Console.ReadKey();
        }
    }
}
