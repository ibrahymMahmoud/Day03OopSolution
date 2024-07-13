using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.Interface_Example_02
{
    internal class SeriesBy2 : ISeries
    {
        
        public int Current { get; set; }
        public void GetNext()
        {
            Current += 2;
        }

        public void Reset()
        {
             Current = 0;
        }
    }
}
