using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.BuiltinInterfaces
{
    internal class Department : ICloneable
    {
        public string? Name { get; set; }
        public int id;
        public  object Clone()
        {
            return new Department()
            {
                Name = this.Name,
                id = this.id
            };
        }
    }
}
