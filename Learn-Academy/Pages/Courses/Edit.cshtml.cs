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
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Course-Admin, Teacher")]
    public class EditModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public EditModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);

            if (Course == null)
            {
                return NotFound();
            }

            if (Course.Author == User.Identity.Name || User.IsInRole("Admin") || User.IsInRole("Course-Admin"))
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

            _context.Attach(Course).State = EntityState.Modified;
            if ((User.IsInRole("Teacher") && Course.Author == User.Identity.Name) || User.IsInRole("Admin") || User.IsInRole("Course-Admin"))
            {
                try
                {
                    //await _context.SaveChangesAsync();
                    if (await _context.SaveChangesAsync() > 0)
                    {
                        // Create an auditrecord object
                        var auditrecord = new AuditRecord();
                        auditrecord.AuditActionType = "Edit Course Record";
                        auditrecord.DateTimeStamp = DateTime.Now;
                        auditrecord.KeyCourseFieldID = Course.ID;
                        // Get current logged-in user
                        var userID = User.Identity.Name.ToString();
                        auditrecord.Username = userID;

                        _context.AuditRecords.Add(auditrecord);
                        await _context.SaveChangesAsync();
                    }
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CourseExists(Course.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            
            return RedirectToPage("./Index");
        }

        private bool CourseExists(int id)
        {
            return _context.Course.Any(e => e.ID == id);
        }
    }
}
