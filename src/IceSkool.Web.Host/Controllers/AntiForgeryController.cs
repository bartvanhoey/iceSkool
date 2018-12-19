using Microsoft.AspNetCore.Antiforgery;
using IceSkool.Controllers;

namespace IceSkool.Web.Host.Controllers
{
    public class AntiForgeryController : IceSkoolControllerBase
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
