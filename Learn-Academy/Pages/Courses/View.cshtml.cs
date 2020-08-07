using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Learn_Academy.Pages.Courses
{
    public class ViewModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public ViewModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public Course current_course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            current_course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);
            var current_user = await _context.Users.FirstOrDefaultAsync(m => m.Email == User.Identity.Name);
            var current_membership = await _context.Membership.FirstOrDefaultAsync(m => m.ApplicationUser.Id == current_user.Id);

            if (current_course == null)
            {
                return NotFound();
            }
            if ( current_membership == null)
            {
                if ( User.IsInRole("Admin") )
                {
                    ViewData["Video"] = current_course;
                    return Page();
                }
            }
            else if (current_membership.Plan == 1 || current_membership.Plan == 2 || current_membership.Plan == 3 )
            {
                if (current_membership.ExpiryDate <= DateTime.Now)
                {
                    ViewData["Video"] = current_course;
                    return Page();
                }
            }

            return NotFound();
        }
    }
}