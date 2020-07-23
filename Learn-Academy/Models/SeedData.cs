using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;

namespace Learn_Academy.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Learn_AcademyContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<Learn_AcademyContext>>()))
            {
                // Look for any movies.
                if (context.Course.Any())
                {
                    return;   // DB has been seeded
                }

                context.Course.AddRange(
                    new Course
                    {
                        Name = "Programming - Python",
                        CourseDate = DateTime.Parse("2020-9-10"),
                        Type = "Online",
                        Price = 159.99M
                    },

                    new Course
                    {
                        Name = "Wallet Making",
                        CourseDate = DateTime.Parse("2020-9-13"),
                        Type = "On-Site",
                        Price = 179.99M
                    },

                    new Course
                    {
                        Name = "Knitting",
                        CourseDate = DateTime.Parse("2020-9-13"),
                        Type = "Online",
                        Price = 49.99M
                    },

                    new Course
                    {
                        Name = "Deep Learning",
                        CourseDate = DateTime.Parse("2020-9-15"),
                        Type = "Online",
                        Price = 189.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
