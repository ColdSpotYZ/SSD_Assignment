﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Learn_Academy.Models;
using System.Security.Claims;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Stripe;
using Stripe.Checkout;

namespace Learn_Academy.Pages.Purchase
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateModel(Learn_Academy.Models.Learn_AcademyContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }


        public IActionResult OnGet()
        {
            StripeConfiguration.ApiKey = "sk_test_51HByJHLjxHvQGXDJcgeIcWdE7AAyefjbnWgzzbuRwlCD4vjW4ZFMNLmuPepWNP57v7FxC2gQzK8PwBhsrG55Fiso00FUO4bB7P";

            var options1 = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> {
                "card",
            },
            LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    Price = "price_1HByP9LjxHvQGXDJ0DTBf5rO",
                    Quantity = 1,
                },
            },
                Mode = "subscription",
                SuccessUrl = "http://coldspot.me",
                CancelUrl = "http://coldspot.me",
            };

            var service = new SessionService();
            Session session = service.Create(options1);
            ViewData["Session_id_1"] = session.Id;
            var options2 = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> {
                "card",
            },
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    Price = "price_1HByPRLjxHvQGXDJMtPKOSwV",
                    Quantity = 1,
                },
            },
                Mode = "subscription",
                SuccessUrl = "http://coldspot.me",
                CancelUrl = "http://coldspot.me",
            };
            var service2 = new SessionService();
            Session session2 = service.Create(options2);
            ViewData["Session_id_2"] = session2.Id;
            var options3 = new SessionCreateOptions
            {
                PaymentMethodTypes = new List<string> {
                "card",
            },
                LineItems = new List<SessionLineItemOptions>
            {
                new SessionLineItemOptions
                {
                    Price = "price_1HByPjLjxHvQGXDJs2bWLAfc",
                    Quantity = 1,
                },
            },
                Mode = "payment",
                SuccessUrl = "http://coldspot.me",
                CancelUrl = "http://coldspot.me",
            };
            var service3 = new SessionService();
            Session session3 = service.Create(options3);
            ViewData["Session_id_3"] = session3.Id;
            return Page();
        }

        [BindProperty]
        public Membership Membership { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Console.WriteLine("Invalid page");
                return Page();
            }
            var current_user = await _userManager.FindByNameAsync(User.Identity.Name);
            var prev_membership = _context.Membership.LastOrDefault(m => m.ApplicationUser.Id == current_user.Id);
            if (prev_membership != null)
            {
                if (prev_membership.ExpiryDate >= DateTime.Now)
                {
                    ModelState.AddModelError(String.Empty, "Membership still in effect.");
                    return Page();
                }
            }

            Membership.Date = DateTime.Now;
            if (Membership.Plan == 1)
            {
                Membership.ExpiryDate = Membership.Date.AddMonths(1);
            }
            else if (Membership.Plan == 2)
            {
                Membership.ExpiryDate = Membership.Date.AddYears(1);
            }
            else if (Membership.Plan == 3)
            {
                Membership.ExpiryDate = Membership.Date.AddYears(10);
            }
            Membership.ApplicationUser = await _userManager.FindByNameAsync(User.Identity.Name);


            _context.Membership.Add(Membership);
            await _context.SaveChangesAsync();

            //if (await _context.SaveChangesAsync() > 0)
            //{
            //    // Create an auditrecord object
            //    var auditrecord = new AuditRecord();
            //    auditrecord.AuditActionType = "Add Purchase Record";
            //    auditrecord.DateTimeStamp = DateTime.Now;
            //    auditrecord.KeyCourseFieldID = 1000;
            //    // Get current logged-in user
            //    var userID = User.Identity.Name.ToString();
            //    auditrecord.Username = userID;

            //    _context.AuditRecords.Add(auditrecord);
            //    await _context.SaveChangesAsync();
            //}

            return RedirectToPage("./Index");
        }
    }
}