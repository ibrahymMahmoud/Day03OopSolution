using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day03OopSolution.BuiltinInterfaces
{
    class Employee : ICloneable , IComparable
    {
        public int Id;
        public string? Name;
        public decimal salary;
        public override string ToString()
        {
            return  $"id= {this.Id} , name= {this.Name} , salary= {this.salary}";
        }
        public Department Department;
        public Employee() { }
        public Employee( Employee employee)
        {
            Id = employee.Id ;
            Name = employee.Name ;
            salary = employee.salary;
            Department = (Department) employee.Department.Clone() ;
        }

        public object Clone() 
        {
            return new Employee()
            {
                Id= this.Id,
                Name= this.Name,
                salary= this.salary,
                Department = (Department) this.Department.Clone()
            };
        }

        public int CompareTo(object? obj)
        {
            Employee employee = (Employee?) obj ;
            if( this.salary > employee?.salary )
                return 1 ;
            else if(this.salary < employee?.salary)
                return -1 ;
            return 0;
        }
    }
}
