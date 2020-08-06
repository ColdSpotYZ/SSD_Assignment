using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Learn_Academy.Models;

namespace Learn_Academy.Pages.Audit
{
    public class CreateModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public CreateModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            if (User.IsInRole("Admin"))
            {
                return Page();
            }

            return NotFound();
        }

        [BindProperty]
        public AuditRecord AuditRecord { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            if (User.IsInRole("Admin"))
            {
                _context.AuditRecords.Add(AuditRecord);
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}