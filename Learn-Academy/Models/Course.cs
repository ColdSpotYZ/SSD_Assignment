using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Learn_Academy.Models
{
    public class Course
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Course Date")]
        [DataType(DataType.Date)]
        public DateTime CourseDate { get; set; }
        public string Type { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }
    }
}
