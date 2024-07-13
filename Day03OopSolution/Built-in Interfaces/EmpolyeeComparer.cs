using Day03OopSolution.BuiltinInterfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.Built_in_Interfaces
{
    internal class EmpolyeeComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            Employee? employeeX =(Employee?)  x  ;
            Employee? employeeY = (Employee?) y;

            return employeeX?.Id.CompareTo(employeeY?.Id) ?? (employeeY is null ? 0 : -1) ;
        }
    }
}
