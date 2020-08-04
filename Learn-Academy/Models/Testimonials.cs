using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Learn_Academy.Models
{
    public class Testimonials
    {
        public int ID { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string Details { get; set; }
    }
}
