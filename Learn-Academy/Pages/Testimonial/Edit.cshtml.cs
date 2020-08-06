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

namespace Learn_Academy.Pages.Testimonial
{
    [Authorize(Roles = "Admin, Course-Admin, Role-Admin , Students, Teacher")]
    public class EditModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public EditModel(Learn_Academy.Models.Learn_AcademyContext context)
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

            if (Testimonials.Author == User.Identity.Name || User.IsInRole("Admin") || User.IsInRole("Role-Admin") || User.IsInRole("Course-Admin"))
            {
                return Page();
            }

            return NotFound();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Testimonials).State = EntityState.Modified;

            try
            {
                if (Testimonials.Author == User.Identity.Name || User.IsInRole("Admin") || User.IsInRole("Role-Admin") || User.IsInRole("Course-Admin"))
                {
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestimonialsExists(Testimonials.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TestimonialsExists(int id)
        {
            return _context.Testimonials.Any(e => e.ID == id);
        }
    }
}
