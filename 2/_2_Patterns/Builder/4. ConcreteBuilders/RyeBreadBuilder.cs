using Builder.Builder;
using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilders
{
    class RyeBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {

        }

        public override void SetRyeFlour()
        {
            this.Bread.RyeFlour = new Flour { Sort = "1st sort" };
        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetWheatFlour()
        {

        }
    }
}
