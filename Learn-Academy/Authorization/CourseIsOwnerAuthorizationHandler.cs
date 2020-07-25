using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Learn_Academy.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Microsoft.AspNetCore.Identity;

namespace Learn_Academy.Authorization
{
    public class CourseIsOwnerAuthorizationHandler : AuthorizationHandler<OperationAuthorizationRequirement, Course>
    {
        UserManager<IdentityUser> _userManager;

        public CourseIsOwnerAuthorizationHandler(UserManager<IdentityUser>
            userManager)
        {
            _userManager = userManager;
        }

        protected override Task
            HandleRequirementAsync(AuthorizationHandlerContext context,
                                   OperationAuthorizationRequirement requirement,
                                   Course resource)
        {
            if (context.User == null || resource == null)
            {
                // Return Task.FromResult(0) if targeting a version of
                // .NET Framework older than 4.6:
                return Task.CompletedTask;
            }

            // If we're not asking for CRUD permission, return.

            

            if (resource.Author == _userManager.GetUserName(context.User))
            {
                context.Succeed(requirement);
            }

            return Task.CompletedTask;
        }

    }
}
