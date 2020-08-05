using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Purchase
{
    public class DetailsModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DetailsModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public Membership Membership { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Membership = await _context.Membership.FirstOrDefaultAsync(m => m.PurchaseId == id);

            if (Membership == null)
            {
                return NotFound();
            }

            if (Membership.ApplicationUser != User.Identity)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
