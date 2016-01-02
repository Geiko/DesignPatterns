using Builder.Parts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Product
{
    class Bread
    {
        public Flour WheatFlour { get; set; }
        public Flour RyeFlour { get; set; }

        public Salt Salt { get; set; }

        public Additives Additives { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            if (WheatFlour != null)
            {
                sb.Append(" Wheat flour used " + WheatFlour.Sort + "\n");
            }
            if (RyeFlour != null)
            {
                sb.Append(" Rye Flour used " + RyeFlour.Sort + "\n");
            }
            if (Salt != null)
            {
                sb.Append(" Salt \n");
            }
            if (Additives != null)
            {
                sb.Append(" Additives : " + Additives.Name + "\n");
            }

            return sb.ToString();
        }

    }
}
