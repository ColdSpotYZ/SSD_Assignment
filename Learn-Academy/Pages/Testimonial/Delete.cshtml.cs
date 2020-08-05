using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Testimonial
{
    [Authorize(Roles = "Admin, Course-Admin, Role-Admin, Students, Teacher")]
    public class DeleteModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DeleteModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Testimonials Testimonials { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Testimonials = await _context.Testimonials.FirstOrDefaultAsync(m => m.ID == id);

            if (Testimonials == null)
            {
                return NotFound();
            }

            if (Testimonials.Author != User.Identity.Name)
            {
                return NotFound();
            }    

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Testimonials = await _context.Testimonials.FindAsync(id);

            if (Testimonials != null)
            {
                _context.Testimonials.Remove(Testimonials);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
