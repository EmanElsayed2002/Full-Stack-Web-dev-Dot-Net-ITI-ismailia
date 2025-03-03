using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Student
    {
        public int ID { get; set; }
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; }
        public int DepartmentId  { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public virtual Department Department { get; set; }

        public override string ToString()
        {
            return $"{ID} {Name} {DepartmentId} {Salary} {Age}";
        }
    }
}
