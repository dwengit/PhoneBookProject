using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PhoneBookProject.Controllers;

namespace PhoneBookProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : PhoneBookProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
