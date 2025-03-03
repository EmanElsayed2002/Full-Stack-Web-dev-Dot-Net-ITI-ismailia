using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab02.Models
{
    public class Employee 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
        public int DeptId { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name} {Salary} {Age} {DeptId}";
        }
    }
}
