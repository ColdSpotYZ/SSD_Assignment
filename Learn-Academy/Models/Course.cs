using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net;
using System.Security.Policy;

namespace Learn_Academy.Models
{
    public class Course
    {
        // user ID from AspNetUser table.
        // public string OwnerID { get; set; }

        public int ID { get; set; }
        public string Name { get; set; }

        [Display(Name = "Course Date")]
        [DataType(DataType.Date)]
        public DateTime CourseDate { get; set; }

        public string Category { get; set; }
        public string Author { get; set; }

        public string Description { get; set; }
        
    }
}
