using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;

namespace Learn_Academy.Pages.Courses.Ratings
{
    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IList<Rating> Rating { get;set; }

        public async Task OnGetAsync()
        {
            Rating = await _context.Rating.ToListAsync();
        }
    }
}
