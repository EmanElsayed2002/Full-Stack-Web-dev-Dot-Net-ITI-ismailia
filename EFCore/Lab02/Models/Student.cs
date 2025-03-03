using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Range(16 , 99)]
        public int Age { get; set; }

        // Navigation property
        public int TrackId { get; set; }
        public virtual Track Track { get; set; }
    }
}
