using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.Interface
{
    internal class MyType : IMyType /* : --> Implements */
    {
        public int Salary 
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public void Myfun()
        {
            Console.WriteLine("implement of signature of interface");
        }
    }
}
