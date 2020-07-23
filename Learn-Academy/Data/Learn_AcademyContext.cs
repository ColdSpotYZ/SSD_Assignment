using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Learn_Academy.Models
{
    public class Learn_AcademyContext : DbContext
    {
        public Learn_AcademyContext (DbContextOptions<Learn_AcademyContext> options)
            : base(options)
        {
        }

        public DbSet<Learn_Academy.Models.Course> Course { get; set; }
    }
}
