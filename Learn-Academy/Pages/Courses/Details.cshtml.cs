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

            //var Membershiplist = new List<Membership>();
            //foreach (var i in _context.Membership.ToList())
            //{
            //    Membershiplist.Add(new Membership() { ApplicationUser = i.ApplicationUser, ConcurrencyStamp = i.ConcurrencyStamp, Id = i.Id, Date = i.Date, ExpiryDate = i.ExpiryDate, Name = i.Name, NormalizedName = i.NormalizedName, PurchaseId = i.PurchaseId, Plan = i.Plan });
            //}
            ViewData["Membership"] = _context.Membership;

            var temp = _context.Membership;
            Course = await _context.Course.FirstOrDefaultAsync(m => m.ID == id);

            if (Course == null)
            {
                return NotFound();
            }
            return Page();
        }

    }
}
