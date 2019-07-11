using Microsoft.AspNetCore.Antiforgery;
using OpenPOS.Users.Controllers;

namespace OpenPOS.Users.Web.Host.Controllers
{
    public class AntiForgeryController : UsersControllerBase
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
