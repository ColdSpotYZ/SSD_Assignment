using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;


namespace Learn_Academy.Pages.Testimonial
{
    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IList<Testimonials> Testimonials { get;set; }

        public async Task OnGetAsync()
        {
            if (User.Identity.Name != null)
            {
                var current_user = await _context.Users.FirstOrDefaultAsync(m => m.Email == User.Identity.Name);
                var userMembership = await _context.Membership.FirstOrDefaultAsync(m => m.ApplicationUser.Email == current_user.Email);
                ViewData["currentUserMembership"] = userMembership;
            }
            Testimonials = await _context.Testimonials.ToListAsync();
        }
    }
}
