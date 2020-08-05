using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Learn_Academy.Controllers;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Course-Admin, Teacher")]
    public class DetailsModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DetailsModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public Course Course { get; set; }
        
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var Membershiplist = new List<Membership>();
            foreach (var i in _context.Membership)
            {
                Membershiplist.Add(new Membership() {ApplicationUser = i.ApplicationUser, ExpiryDate = i.ExpiryDate, Plan = i.Plan, PurchaseId = i.PurchaseId, Date = i.Date});
            }
            ViewData["Membership"] = Membershiplist;


            Course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
