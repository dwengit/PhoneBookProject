using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using PhoneBookProject.Controllers;

namespace PhoneBookProject.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : PhoneBookProjectControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
