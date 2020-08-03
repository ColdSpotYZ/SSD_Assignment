using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Learn_Academy.Models;

namespace Learn_Academy.Models
{
    public class Learn_AcademyContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public Learn_AcademyContext (DbContextOptions<Learn_AcademyContext> options)
            : base(options)
        {
        }

        public Learn_AcademyContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Learn_Academy.Models.Course> Course { get; set; }

        public DbSet<Learn_Academy.Models.Rating> Rating { get; set; }

        public DbSet<Learn_Academy.Models.AuditRecord> AuditRecords { get; set; }

        public DbSet<Learn_Academy.Models.Membership> Membership { get; set; }

        public DbSet<Learn_Academy.Models.Testimonials> Testimonials { get; set; }

    }
}
