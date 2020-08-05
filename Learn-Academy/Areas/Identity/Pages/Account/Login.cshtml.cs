using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using System.Collections;

namespace Learn_Academy.Areas.Identity.Pages.Account
{
    [AllowAnonymous]
    public class LoginModel : PageModel
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ILogger<LoginModel> _logger;
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;

        private async Task<CaptchaVerification> VerifyCaptcha()
        {
            string userIP = string.Empty;
            var ipAddress = Request.HttpContext.Connection.RemoteIpAddress;
            if (ipAddress != null) userIP = ipAddress.MapToIPv4().ToString();

            var captchaResponse = Request.Form["g-recaptcha-response"];
            var payload = string.Format("&secret={0}&remoteip={1}&response={2}",
                "6LeVnboZAAAAAHssNKqDOEXH6kfNJVJlOjAKjJZc",
                userIP,
                captchaResponse
                );

            var client = new HttpClient();
            client.BaseAddress = new Uri("https://www.google.com");
            var request = new HttpRequestMessage(HttpMethod.Post, "/recaptcha/api/siteverify");
            request.Content = new StringContent(payload, Encoding.UTF8, "application/x-www-form-urlencoded");
            var response = await client.SendAsync(request);
            return JsonConvert.DeserializeObject<CaptchaVerification>(response.Content.ReadAsStringAsync().Result);
        }

        public class CaptchaVerification
        {
            public CaptchaVerification()
            {
            }

            [JsonProperty("success")]
            public bool Success { get; set; }

            [JsonProperty("error-codes")]
            public IList Errors { get; set; }
        }

        public LoginModel(SignInManager<ApplicationUser> signInManager, ILogger<LoginModel> logger, Learn_Academy.Models.Learn_AcademyContext context)
        {
            _signInManager = signInManager;
            _logger = logger;
            _context = context;
        }

        [BindProperty]
        public InputModel Input { get; set; }

        public IList<AuthenticationScheme> ExternalLogins { get; set; }

        public string ReturnUrl { get; set; }

        [TempData]
        public string ErrorMessage { get; set; }

        public class InputModel
        {
            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        }

        public async Task OnGetAsync(string returnUrl = null)
        {
            if (!string.IsNullOrEmpty(ErrorMessage))
            {
                ModelState.AddModelError(string.Empty, ErrorMessage);
            }

            returnUrl = returnUrl ?? Url.Content("~/");

            // Clear the existing external cookie to ensure a clean login process
            await HttpContext.SignOutAsync(IdentityConstants.ExternalScheme);

            ExternalLogins = (await _signInManager.GetExternalAuthenticationSchemesAsync()).ToList();

            ReturnUrl = returnUrl;
        }

        public async Task<IActionResult> OnPostAsync(string returnUrl = null)
        {
            returnUrl = returnUrl ?? Url.Content("~/");
            ReturnUrl = returnUrl;
            //Verify the Captcha
            var resultCaptcha = await VerifyCaptcha();
            //Captcha was not a succes
            if (!resultCaptcha.Success)
            {
                ModelState.AddModelError("", "Captcha is not valid");
                // Login failed attempt - create an audit record
                var auditrecord = new AuditRecord();
                auditrecord.AuditActionType = "Failed ReCAPTCHA";
                auditrecord.DateTimeStamp = DateTime.Now;
                auditrecord.KeyCourseFieldID = 999;
                // 999 – dummy record 

                auditrecord.Username = Input.Email;
                // save the email used for the failed login
                _context.AuditRecords.Add(auditrecord);
                await _context.SaveChangesAsync();
                //Return to the login page
                return Page();
            }
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = await _signInManager.PasswordSignInAsync(Input.Email, Input.Password, Input.RememberMe, lockoutOnFailure: true);
                if (result.Succeeded)
                {
                    _logger.LogInformation("User logged in.");
                    // Login successful attempt - create an audit record
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Successful Login";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 999;
                    // 998 – dummy record 

                    auditrecord.Username = Input.Email;
                    // save the email used for the successful login
                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();
                    return LocalRedirect(returnUrl);
                }
                else
                {
                    // Login failed attempt - create an audit record
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Failed Login";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 999;
                    // 999 – dummy record 

                    auditrecord.Username = Input.Email;
                    // save the email used for the failed login
                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();
                }

                if (result.RequiresTwoFactor)
                {
                    return RedirectToPage("./LoginWith2fa", new { ReturnUrl = returnUrl, RememberMe = Input.RememberMe });
                }
                if (result.IsLockedOut)
                {
                    _logger.LogWarning("User account locked out.");
                    return RedirectToPage("./Lockout");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                    return Page();
                }
            }

            // If we got this far, something failed, redisplay form
            return Page();
        }
    }
}
