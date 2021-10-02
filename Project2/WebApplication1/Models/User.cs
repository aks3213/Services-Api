using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class User
    {
        [Key]
        public int Id { get; set;  }
        [Required]
        public string Name { get; set; }
        /*
        public DateTime DOB { get; set; }
        */
        [Required]
        public string Gender { get; set; }
    }
}
