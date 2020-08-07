using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Authorization;
using Learn_Academy.Models;

namespace Learn_Academy.Pages.Courses.My_Courses
{
    [Authorize(Roles = "Teacher")]
    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            
            List<Course> ListofCourses = _context.Course.ToList();
            ViewData["Course"] = ListofCourses;
            if (User.IsInRole("Teacher"))
            {
                return Page();
            }
            return NotFound();
        }
    }
}