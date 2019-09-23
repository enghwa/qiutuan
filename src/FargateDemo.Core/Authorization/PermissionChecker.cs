using Abp.Authorization;
using FargateDemo.Authorization.Roles;
using FargateDemo.Authorization.Users;

namespace FargateDemo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
