using Microsoft.AspNetCore.Antiforgery;
using PhoneBookProject.Controllers;

namespace PhoneBookProject.Web.Host.Controllers
{
    public class AntiForgeryController : PhoneBookProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
