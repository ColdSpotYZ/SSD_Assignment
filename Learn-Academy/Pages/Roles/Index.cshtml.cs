using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Roles
{
    public class IndexModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;

        public IndexModel(RoleManager<ApplicationRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public List<ApplicationRole> ApplicationRole { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                ApplicationRole = await _roleManager.Roles.ToListAsync();
                return Page();
            }

            return NotFound();
            // Get a list of roles

        }

    }
}