using System;
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
                SuccessUrl = "https://example.com/success?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = "https://example.com/cancel",
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
                SuccessUrl = "https://example.com/success?session_id={CHECKOUT_SESSION_ID}",
                CancelUrl = "https://example.com/cancel",
            };

            var service2 = new SessionService();
            Session session2 = service.Create(options2);
            ViewData["Session_id_2"] = session2.Id;
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

            return RedirectToPage("./Index");
        }
    }
}