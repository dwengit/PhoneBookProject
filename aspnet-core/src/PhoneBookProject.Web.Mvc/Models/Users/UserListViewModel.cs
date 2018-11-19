using System.Collections.Generic;
using PhoneBookProject.Roles.Dto;
using PhoneBookProject.Users.Dto;

namespace PhoneBookProject.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
