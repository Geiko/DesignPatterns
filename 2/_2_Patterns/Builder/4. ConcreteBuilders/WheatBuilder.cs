using Builder.Builder;
using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.ConcreteBuilders
{
    class WheatBreadBuilder : BreadBuilder
    {
        public override void SetAdditives()
        {
            this.Bread.Additives = new Additives { Name = "drogggi, vanilla" };
        }

        public override void SetRyeFlour()
        {

        }

        public override void SetSalt()
        {
            this.Bread.Salt = new Salt();
        }

        public override void SetWheatFlour()
        {
            this.Bread.WheatFlour = new Flour { Sort = "Highest sort" };
        }
    }
}
