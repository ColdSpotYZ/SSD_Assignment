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
    [Authorize(Roles = "Admin, Course-Admin, Teacher, Students")]
    public class DetailsModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DetailsModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Currentid = id;
            ViewData["CurrentID"] = Currentid;
            var current_user = await _context.Users.FirstOrDefaultAsync(m => m.Email == User.Identity.Name);
            var current_membership = _context.Membership.Where(m => m.Id == current_user.Id).ToList();
            ViewData["Membership"] = current_membership;


            var temp = _context.Membership;
            Course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
