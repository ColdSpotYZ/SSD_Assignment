﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;

namespace Learn_Academy.Pages.Testimonial
{
    public class IndexModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public IndexModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IList<Testimonials> Testimonials { get;set; }

        public async Task OnGetAsync()
        {
            Testimonials = await _context.Testimonials.ToListAsync();
        }
    }
}