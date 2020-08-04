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
    public class DetailsModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public DetailsModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public Testimonials Testimonials { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Testimonials = await _context.Testimonials.FirstOrDefaultAsync(m => m.ID == id);

            if (Testimonials == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}