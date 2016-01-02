using Cars._1._AbstractFactory;
using Cars._2._AbstractProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars._1._Client
{
    class Porshe911
        {
            private Engine engine;
            private Gear gear;

            public Porshe911(Porshe911Factory factory)
            {
                engine = factory.CreateEngine();
                gear = factory.CreateGear();
            }

            public void Porshe911Engine()
            {
                engine.HasVolume();
            }

            public void Porshe911Gear()
            {
                gear.HasStick();
            }
        }
    }
