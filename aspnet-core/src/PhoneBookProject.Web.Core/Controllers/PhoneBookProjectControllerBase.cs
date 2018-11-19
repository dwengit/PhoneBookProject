using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace PhoneBookProject.Controllers
{
    public abstract class PhoneBookProjectControllerBase: AbpController
    {
        protected PhoneBookProjectControllerBase()
        {
            LocalizationSourceName = PhoneBookProjectConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
