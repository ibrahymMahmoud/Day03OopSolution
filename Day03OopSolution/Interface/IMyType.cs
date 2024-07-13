using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.Interface
{
    internal interface IMyType
    {
        //Code contract between devolper how do interface and how implement that interface
        //can write in interface
        // 1-signature for method
        public void Myfun();
        // 2-singature for property
        public int Salary {  get; set; }
        // 3-deafault implemented function
        public void Print()
        {
            Console.WriteLine("hello from default implemented method --> C# 8.0 Feature [ .Net Core 3.1 (2019) ]");
        }

        //Default Access Modifier inside the interface is "public"
        //Private Access Modifier inside the interface is not allowed for signatures
        private void Fun () 
        {
            Console.WriteLine("Hello from Helper Method (allowed only inside interface)");
        }


    }
}
