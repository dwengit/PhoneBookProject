using Abp.AspNetCore.Mvc.ViewComponents;

namespace PhoneBookProject.Web.Views
{
    public abstract class PhoneBookProjectViewComponent : AbpViewComponent
    {
        protected PhoneBookProjectViewComponent()
        {
            LocalizationSourceName = PhoneBookProjectConsts.LocalizationSourceName;
        }
    }
}
