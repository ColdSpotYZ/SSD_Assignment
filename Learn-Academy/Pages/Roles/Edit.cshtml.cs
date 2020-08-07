using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Roles
{
    public class EditModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public EditModel(RoleManager<ApplicationRole> roleManager, Learn_Academy.Models.Learn_AcademyContext context)
        {
            _roleManager = roleManager;
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ApplicationRole appRole = await _roleManager.FindByIdAsync(ApplicationRole.Id);

            appRole.Id = ApplicationRole.Id;
            appRole.Name = ApplicationRole.Name;
            appRole.Description = ApplicationRole.Description;
            
            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                IdentityResult roleRuslt = await _roleManager.UpdateAsync(appRole);

                if (roleRuslt.Succeeded)
                {
                    // Create an auditrecord object
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Edit Role Record";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 998;
                    // Get current logged-in user
                    var userID = User.Identity.Name.ToString();
                    auditrecord.Username = userID;

                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();
                }

                return RedirectToPage("./Index");

            }
            return NotFound();


        }

    }
}