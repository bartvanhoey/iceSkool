using Abp.Authorization;
using IceSkool.Authorization.Roles;
using IceSkool.Authorization.Users;

namespace IceSkool.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
