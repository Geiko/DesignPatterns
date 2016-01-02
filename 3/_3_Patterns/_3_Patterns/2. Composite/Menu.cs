using _3_Patterns.MenuComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Patterns.Composite
{
    class Menu : Component
    {
        private List<Component> components = new List<Component>();


        public Menu(string name) : base(name)
        {
        }


        public override void Add(Component component)
        {
            components.Add(component);
        }


        public override void Remove(Component component)
        {
            components.Remove(component);
        }


        public override void Print()
        {
            Console.WriteLine("\n Menu : " + name + "-----");
            Console.WriteLine("\n   Utilities :");

            for (int i = 0; i < components.Count; i++)
            {
                components[i].Print();
                
            }
        }
    }
}
