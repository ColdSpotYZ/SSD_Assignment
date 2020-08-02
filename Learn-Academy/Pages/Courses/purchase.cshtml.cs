using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Teacher")]
    public class PurchaseModel : PageModel
    {

        private readonly Learn_Academy.Models.Learn_AcademyContext _context;


        public PurchaseModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Membership Membership { get; set; }

        
        public async Task<IActionResult> OnPostAsync()
        {
            if (Membership.Plan != 1 || Membership.Plan != 2 || Membership.Plan != 3)
            {
                ModelState.AddModelError("Plan",
                    $"{Membership.Plan} is not a valid value.");
            }
            if (!ModelState.IsValid)
            {
                return Page();
            }

            Membership.Date = DateTime.Now;
            if (Membership.Plan == 1)
            {
                Membership.ExpiryDate = Membership.Date.AddMonths(1);
            }
            else if (Membership.Plan == 2)
            {
                Membership.ExpiryDate = Membership.Date.AddYears(1);
            }
            else if (Membership.Plan == 3)
            {
                Membership.ExpiryDate = Membership.Date.AddYears(10);
            }
            Membership.ApplicationUser = (ApplicationUser) HttpContext.User.Identity;
            
            _context.Membership.Add(Membership);

            return RedirectToPage("./Index");
        }
    }
}