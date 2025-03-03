using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF01.Models
{
    public class Department
    {
        public int Id { get; set; }
        [MinLength(2)]
        [MaxLength(25)]
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
