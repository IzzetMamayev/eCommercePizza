using Microsoft.AspNetCore.Mvc;
using webUI.Helpers;

namespace webUI.Areas.User.Controllers
{
    [CustomAuthorize(Roles = "User")]
    [Area("User")]
    public class BaseController : Controller
    {
        public IActionResult Index()
        {
            return View();  
        }
    }
}
