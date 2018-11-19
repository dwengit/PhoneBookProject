using System.Collections.Generic;
using PhoneBookProject.Roles.Dto;

namespace PhoneBookProject.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}