using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using System.IO;
using Learn_Academy.Utilities;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Course-Admin, Teacher")]
    public class CreateModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public CreateModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (Course.Author == User.Identity.Name)
            {
                _context.Course.Add(Course);

            }
            //await _context.SaveChangesAsync();
            Course.image = "Default.jpg";

            if (await _context.SaveChangesAsync() > 0)
            {
                // Create an auditrecord object
                var auditrecord = new AuditRecord();
                auditrecord.AuditActionType = "Add Course Record";
                auditrecord.DateTimeStamp = DateTime.Now;
                auditrecord.KeyCourseFieldID = Course.ID;
                // Get current logged-in user
                var userID = User.Identity.Name.ToString();
                auditrecord.Username = userID;

                _context.AuditRecords.Add(auditrecord);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}