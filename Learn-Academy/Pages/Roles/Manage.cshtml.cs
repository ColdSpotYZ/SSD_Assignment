﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Learn_Academy.Pages.Roles
{
    public class ManageModel : PageModel
    {
        private readonly Learn_Academy.Models.Learn_AcademyContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<ApplicationRole> _roleManager;

        public ManageModel(Learn_Academy.Models.Learn_AcademyContext context, UserManager<ApplicationUser> userManager, RoleManager<ApplicationRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public SelectList RolesSelectList;
        //contain  a list of roles to populate select box
        public SelectList UsersSelectList;
        // contain  a list of Users to populate select box

        public string selectedrolename { set; get; }
        public string selectedusername { set; get; }
        public string delrolename { set; get; }
        public string delusername { set; get; }

        public int usercountinrole { set; get; }
        public IList<ApplicationRole> Listroles { get; set; }

        public string ListUsersInRole(string rolename)
        {
            // Method - return a string showing a list of users  based on specified role as parameter
            string strListUsersInRole = "";
            string roleid = _roleManager.Roles.SingleOrDefault(u => u.Name == rolename).Id;

            // Get no. of users for each specified role
            var count = _context.UserRoles.Where(u => u.RoleId == roleid).Count();
            usercountinrole = count;

            //Get a list of users for each specified role
            var listusers = _context.UserRoles.Where(u => u.RoleId == roleid);

            foreach (var oParam in listusers)
            {    // loop thru each objects-  get username based on userid and append to the returned string
                var userobj = _context.Users.SingleOrDefault(s => s.Id == oParam.UserId);
                strListUsersInRole += "[" + userobj.UserName + "] ";
            }
            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                return strListUsersInRole;
            }

            return null;

        }

        public async Task<IActionResult> OnGetAsync()
        {   //HTTPGet  - when form is being loaded
            //get list of roles and users
            IQueryable<string> RoleQuery = from m in _roleManager.Roles orderby m.Name select m.Name;
            IQueryable<string> UsersQuery = from u in _context.Users orderby u.UserName select u.UserName;

            RolesSelectList = new SelectList(await RoleQuery.Distinct().ToListAsync());
            UsersSelectList = new SelectList(await UsersQuery.Distinct().ToListAsync());
            // Get all the roles 
            var roles = from r in _roleManager.Roles
                        select r;
            Listroles = await roles.ToListAsync();
            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(string selectedusername, string selectedrolename)
        {
            //When the Assign button is pressed 
            if ((selectedusername == null) || (selectedrolename == null))
            {
                return RedirectToPage("Manage");
            }

            ApplicationUser AppUser = _context.Users.SingleOrDefault(u => u.UserName == selectedusername);
            ApplicationRole AppRole = await _roleManager.FindByNameAsync(selectedrolename);

            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                IdentityResult roleResult = await _userManager.AddToRoleAsync(AppUser, AppRole.Name);

                if (roleResult.Succeeded)
                {
                    TempData["message"] = "Role added to this user successfully";
                    // Create an auditrecord object
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Add User Role Record";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 997;
                    // Get current logged-in user
                    var userID = User.Identity.Name.ToString();
                    auditrecord.Username = userID;

                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();

                    return RedirectToPage("Manage");
                }

                return Page();
            }

            return NotFound();


        }

        public async Task<IActionResult> OnPostDeleteUserRoleAsync(string delusername, string delrolename)
        {
            //When the Delete this user from  Role button is pressed 
            if ((delusername == null) || (delrolename == null))
            {
                return RedirectToPage("Manage");
            }
            if (User.IsInRole("Admin") || User.IsInRole("Role-Admin"))
            {
                ApplicationUser user = _context.Users.Where(u => u.UserName.Equals(delusername, StringComparison.CurrentCultureIgnoreCase)).FirstOrDefault();

                if (await _userManager.IsInRoleAsync(user, delrolename))
                {
                    await _userManager.RemoveFromRoleAsync(user, delrolename);

                    // Create an auditrecord object
                    var auditrecord = new AuditRecord();
                    auditrecord.AuditActionType = "Delete User Role Record";
                    auditrecord.DateTimeStamp = DateTime.Now;
                    auditrecord.KeyCourseFieldID = 997;
                    // Get current logged-in user
                    var userID = User.Identity.Name.ToString();
                    auditrecord.Username = userID;

                    _context.AuditRecords.Add(auditrecord);
                    await _context.SaveChangesAsync();

                    TempData["message"] = "Role removed from this user successfully";
                }
            }


            return RedirectToPage("Manage");
        }

    }
}