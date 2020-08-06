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

namespace Learn_Academy.Pages.Purchase
{
    [Authorize(Roles = "Admin, Role-Admin, Course-Admin")]
    public class EditModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public EditModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        [BindProperty]
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
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Membership).State = EntityState.Modified;

            try
            {
                //await _context.SaveChangesAsync();
                if (await _context.SaveChangesAsync() > 0)
                {
                    // Create an auditrecord object
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Edit Purchase Record";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 1000;
                    // Get current logged-in user
                    var userID = User.Identity.Name.ToString();
                    auditrecord.Username = userID;

                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();
                }
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MembershipExists(Membership.PurchaseId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MembershipExists(string id)
        {
            return _context.Membership.Any(e => e.PurchaseId == id);
        }
    }
}
