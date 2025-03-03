using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLab1.Models
{
    public class Student
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        public int TrackId { get; set; }

        public override string ToString()
        {
            return $"{ID} {FirstName} {LastName} {Age} {Salary} {TrackId}";
        }
    }
}
