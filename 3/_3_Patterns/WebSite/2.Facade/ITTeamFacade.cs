using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebSite._3._Subsystems;

namespace WebSite._2.Facade
{
    class ITTeamFacade
    {
        Designer designer;
        Developer developer;
        Tester tester;

        Boolean isBug = true;
        int magicNumber = 3;

        public ITTeamFacade(Designer designer, Developer developer, Tester tester)
        {
            this.designer = designer;
            this.developer = developer;
            this.tester = tester;
        }

        public void Start()
        {
            designer.CreateDesign();
            developer.CreateCode();
            isBug = tester.Test();
        }

        public void Stop()
        {
            int k = 0;
            while (true)
            {
                developer.BugFixing();
                isBug = tester.Test();
                k++;
                if (isBug == false || k >= magicNumber)
                {
                    break;
                }
            }
        }
    }
}
