using Microsoft.AspNetCore.Authorization;

namespace PayApi.Extentions.Policy
{
    public class ManageUserRoleRequirement : IAuthorizationRequirement
    {
        public string UserName { get; private set; }
        public ManageUserRoleRequirement(string username)
        {
            UserName = username;
        }
    }
}
