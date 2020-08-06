using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Identity;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Roles
{
    public class DeleteModel : PageModel
    {
        private readonly RoleManager<ApplicationRole> _roleManager;
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DeleteModel(RoleManager<ApplicationRole> roleManager, Learn_Academy.Models.Learn_AcademyContext context)
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

            if (User.IsInRole("Admin"))
            {
                return Page();
            }
            
            else if (User.IsInRole("Role-Admin"))
            {
                if (ApplicationRole.Name == "Admin")
                {
                    return NotFound();
                }

                else if (ApplicationRole.Name == "Role-Admin")
                {
                    return NotFound();
                }
                else if (ApplicationRole.Name == "Course-Admin")
                {
                    return NotFound();
                }
                else if (ApplicationRole.Name == "Teacher")
                {
                    return NotFound();
                }
                else if (ApplicationRole.Name == "Students")
                {
                    return NotFound();
                }
                else
                {
                    return Page();
                }
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ApplicationRole = await _roleManager.FindByIdAsync(id);

            if (User.IsInRole("Author") || ApplicationRole.Name != "Admin" || ApplicationRole.Name != "Role-Admin" || ApplicationRole.Name != "Course-Admin" || ApplicationRole.Name != "Teacher" || ApplicationRole.Name != "Students")
            {
                if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
                {
                    IdentityResult roleRuslt = await _roleManager.DeleteAsync(ApplicationRole);

                    if (roleRuslt.Succeeded)
                    {
                        // Create an auditrecord object
                        var auditrecord = new AuditRecord();
                        auditrecord.AuditActionType = "Delete Role Record";
                        auditrecord.DateTimeStamp = DateTime.Now;
                        auditrecord.KeyCourseFieldID = 998;
                        // Get current logged-in user
                        var userID = User.Identity.Name.ToString();
                        auditrecord.Username = userID;

                        _context.AuditRecords.Add(auditrecord);
                        await _context.SaveChangesAsync();
                    }
                }
            }
            
                

            return RedirectToPage("./Index");

        }

    }
}