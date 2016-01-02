using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite._2.Facade;

namespace WebSite._1._Client
{
    class Customer
    {
        public void CreateWebSite(ITTeamFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
