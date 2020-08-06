using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Identity;

namespace Learn_Academy.Pages.Roles
{
    public class DetailsModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public DetailsModel(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public ApplicationRole ApplicationRole { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationRole = await _roleManager.FindByIdAsync(id);

            if (ApplicationRole == null)
            {
                return NotFound();
            }

            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                return Page();
            }

            return NotFound();
        }

    }
}