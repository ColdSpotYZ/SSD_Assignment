using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Courses
{

    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public string searchCourses { get; set; }

        public async Task OnGetAsync(string searchCourses)
        {
            var courses = from m in _context.Course
                          select m;

            if (!string.IsNullOrEmpty(searchCourses))
            {
                courses = courses.Where(s => s.Name.Contains(searchCourses));
            }

            Course = await courses.ToListAsync();
        }

        

    }
}
