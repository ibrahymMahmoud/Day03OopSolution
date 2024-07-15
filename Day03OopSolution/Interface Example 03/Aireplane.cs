using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.Interface_Example_03
{
    internal class Aireplane : Vehicle, IMoveable, IFlyable
    {
        void IMoveable.Forward()
        {
            Console.WriteLine("i can forward on ground");
        }

        void IFlyable.Forward()
        {
            Console.WriteLine("i can forward on fly");
        }
        public void Backward()
        {
            Console.WriteLine("i can backward on (fly ,ground)");
        }

        public void Left()
        {
            Console.WriteLine("i can left on (fly , ground)");
        }

        public void Right()
        {
            Console.WriteLine("i can right on (fly , ground)");
        }

        

      
    }
}
