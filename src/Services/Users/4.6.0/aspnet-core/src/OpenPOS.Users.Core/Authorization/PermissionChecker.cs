using Abp.Authorization;
using OpenPOS.Users.Authorization.Roles;
using OpenPOS.Users.Authorization.Users;

namespace OpenPOS.Users.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
