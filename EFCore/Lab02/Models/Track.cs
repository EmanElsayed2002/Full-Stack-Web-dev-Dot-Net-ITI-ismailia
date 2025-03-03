using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITI.Models
{
    public class Track
    {
        [Key]
        public int Id { get; set; }

        [MaxLength(50), Required]
        public string Name { get; set; }

        // Navigation property
        public virtual ICollection<Student> Students { get; set; }

    }
}
