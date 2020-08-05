using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn_Academy.Models
{
    public class Rating : Course
    {
        public int CourseID { get; set; }
        public string CustomerName { get; set; }

        [Column(TypeName = "decimal(3, 2)")]
        public decimal CourseRating { get; set; }
        public string Details { get; set; }

    }
}
