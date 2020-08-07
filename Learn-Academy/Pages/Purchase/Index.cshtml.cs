using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Learn_Academy.Pages.Purchase
{
    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }


        public IList<Membership> Membership { get;set; }



        public async Task OnGetAsync()
        {
            Membership = await _context.Membership.ToListAsync();
            var current_user = await _context.Users.FirstOrDefaultAsync(m => m.Email == User.Identity.Name);
            var current_membership =  _context.Membership.Where(m => m.Id == current_user.Id).ToList();
            ViewData["Membership"] = current_membership;
        }
    }
}
