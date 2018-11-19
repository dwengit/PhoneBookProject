using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace PhoneBookProject.Web.Views
{
    public abstract class PhoneBookProjectRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PhoneBookProjectRazorPage()
        {
            LocalizationSourceName = PhoneBookProjectConsts.LocalizationSourceName;
        }
    }
}
