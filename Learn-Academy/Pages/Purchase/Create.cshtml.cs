using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Learn_Academy.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;

namespace Learn_Academy.Pages.Purchase
{
    public class CreateModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateModel(Learn_Academy.Models.Learn_AcademyContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Membership Membership { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid page");
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
            Membership.ApplicationUser = await _userManager.FindByNameAsync(User.Identity.Name);


            _context.Membership.Add(Membership);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}