using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.AspNetCore.Identity;

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
                // Look for any Courses.
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
                        Price = 159.99M,
                        Author = "tester@gmail.com"
                    },

                    new Course
                    {
                        Name = "Wallet Making",
                        CourseDate = DateTime.Parse("2020-9-13"),
                        Type = "On-Site",
                        Price = 179.99M,
                        Author = "tester@gmail.com"
                    },

                    new Course
                    {
                        Name = "Knitting",
                        CourseDate = DateTime.Parse("2020-9-13"),
                        Type = "Online",
                        Price = 49.99M,
                        Author = "tester@gmail.com"

                    },

                    new Course
                    {
                        Name = "Deep Learning",
                        CourseDate = DateTime.Parse("2020-9-15"),
                        Type = "Online",
                        Price = 189.99M,
                        Author = "tester@gmail.com"

                    }
                );
                // // Look for any users.
                // if (context.Users.Any())
                // {
                //     return;   // DB has been seeded
                // }

                // context.Users.AddRange(
                //     new IdentityUser
                //     {
                //         Id = "a24 - ef927587ba68",
                //         UserName = "admin2@gmail.com",
                //         NormalizedUserName = "ADMIN2@GMAIL.COM",
                //         Email = "admin2@gmail.com",
                //         NormalizedEmail = "ADMIN2@GMAIL.COM",
                //         PasswordHash = "AQAAAAEAACcQAAAAEKkzN9HbiD2j6cnpQDFMkhmnzk0CjpLGie9yHpTbtatUxbFH7nNG3guYvuccGFqhrA==",
                //         SecurityStamp = "BYNQ2V4LVRAZERYR73FC2RK7UOLGQEOC",
                //         ConcurrencyStamp = "c3e12195-2fdb-4b1d-8485-60d11dbebbc5",
                //         PhoneNumberConfirmed = false,
                //         PhoneNumber = null,
                //         TwoFactorEnabled = null,
                //         LockoutEnd = null,
                //         LockoutEnabled = true,
                //         FullName = 
                //     },

                //     new Course
                //     {
                //         Name = "Wallet Making",
                //         CourseDate = DateTime.Parse("2020-9-13"),
                //         Type = "On-Site",
                //         Price = 179.99M
                //     },

                //     new Course
                //     {
                //         Name = "Knitting",
                //         CourseDate = DateTime.Parse("2020-9-13"),
                //         Type = "Online",
                //         Price = 49.99M
                //     },

                //     new Course
                //     {
                //         Name = "Deep Learning",
                //         CourseDate = DateTime.Parse("2020-9-15"),
                //         Type = "Online",
                //         Price = 189.99M
                //     }
                // );
                context.SaveChanges();
            }
        }
    }
}
