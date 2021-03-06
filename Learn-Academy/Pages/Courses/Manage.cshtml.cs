﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Courses
{
    [Authorize(Roles = "Admin, Course-Admin")]
    public class ManageModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        public ManageModel(Learn_Academy.Models.Learn_AcademyContext context)
        {
            _context = context;
        }

        public IList<Course> Course { get;set; }

        public async Task OnGetAsync()
        {
            Course = await _context.Course.ToListAsync();
        }
    }
}
