﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Testimonial
{
    [Authorize(Roles = "Admin, Course-Admin, Role-Admin, Students, Teacher")]
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
        public Testimonials Testimonials { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (Testimonials.Author == User.Identity.Name)
            {
                _context.Testimonials.Add(Testimonials);
            }
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}