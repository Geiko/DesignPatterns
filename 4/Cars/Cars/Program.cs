/*
    Реализовать архитектуру приложений с применением паттернов проектирования:

    1. При производстве автомобиля Porshe 911 применяются различные комплекты сборок.

     В зависимости от требований, автомобиль может комплектоваться 
	
	    механической или автоматической коробкой передач,


     а также различным объемом двигателя:

       - для механической -  в 2.5л. или 3л.

       - для автоматической - в 2л. или 2.5л
*/

using Cars._1._AbstractFactory;
using Cars._1._Client;
using Cars._2._ConcreteFactories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n PORSHE 911 A 2.0 :");
            Porshe911 porshe_A20 = new Porshe911(new Porshe911A20_Factory());
            porshe_A20.Porshe911Engine();
            porshe_A20.Porshe911Gear();

            Console.WriteLine("\n PORSHE 911 A 2.5 :");
            Porshe911 porshe_A25 = new Porshe911(new Porshe911A25_Factory());
            porshe_A25.Porshe911Engine();
            porshe_A25.Porshe911Gear();

            Console.WriteLine("\n PORSHE 911 H 2.5 :");
            Porshe911 porshe_H25 = new Porshe911(new Porshe911H25_Factory());
            porshe_H25.Porshe911Engine();
            porshe_H25.Porshe911Gear();

            Console.WriteLine("\n PORSHE 911 H 3.0 :");
            Porshe911 porshe_H30 = new Porshe911(new Porshe911H30_Factory());
            porshe_H30.Porshe911Engine();
            porshe_H30.Porshe911Gear();

            Console.ReadKey();
        }
    }
}
