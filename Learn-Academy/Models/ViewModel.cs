using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Learn_Academy.Models
{
    public class ViewModel
    {
        public IEnumerable<Membership> Membership { get; set; }
        public IEnumerable<Course> Course { get; set; }
    }
}
