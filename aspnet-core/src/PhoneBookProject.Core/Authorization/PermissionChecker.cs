using Abp.Authorization;
using PhoneBookProject.Authorization.Roles;
using PhoneBookProject.Authorization.Users;

namespace PhoneBookProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
