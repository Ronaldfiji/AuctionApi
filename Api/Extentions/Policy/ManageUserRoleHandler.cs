using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace PayApi.Extentions.Policy
{
    public class ManageUserRoleHandler : AuthorizationHandler<ManageUserRoleRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context,
            ManageUserRoleRequirement requirement)
        {

            if (!context.User.HasClaim(c => c.Type == ClaimTypes.Email))
            {
                //context.Fail();  
                return Task.CompletedTask;
            }
            var email1 = context.User.FindFirstValue(ClaimTypes.Email);
            /*var email = context?.User?.FindFirst(
                 c => c.Type == "Email").Value ?? String.Empty;

            var email2 = context.User.FindFirst(
            c => c.Type == ClaimTypes.DateOfBirth ).Value;*/
            var allRoles = context.User.FindAll(ClaimTypes.Role).Select(r => r.Value).ToList();
                                      //FindAll( c => c.Type == ClaimTypes.Role);

               /**   Check if email is equal to admin@admin.com  OR user have Manager role  **/
            if (context.User.FindFirstValue(ClaimTypes.Email) == requirement.UserName)
            {
                context.Succeed(requirement);
            }  
            else if (allRoles.Any( r => r.Equals("Manager")) || allRoles.Any(r => r.Equals("MasterAdmin")))
            {               
                context.Succeed(requirement);
            }
            //context.Fail();  
            return Task.CompletedTask;
        }
    }
}
