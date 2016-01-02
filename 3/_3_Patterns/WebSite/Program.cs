using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite._1._Client;
using WebSite._2.Facade;
using WebSite._3._Subsystems;

namespace WebSite
{
    class Program
    {
        static void Main(string[] args)
        {
            Designer designer = new Designer();
            Developer developer = new Developer();
            Tester tester = new Tester();

            ITTeamFacade team = new ITTeamFacade(designer, developer, tester);

            Customer customer = new Customer();
            customer.CreateWebSite(team);

            Console.ReadKey();
        }
    }
}
