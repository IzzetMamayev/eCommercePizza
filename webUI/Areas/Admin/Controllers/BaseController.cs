using Microsoft.AspNetCore.Mvc;
using webUI.Helpers;

namespace webUI.Areas.Admin.Controllers
{
    [CustomAuthorize(Roles = "Admin")]
    [Area("Admin")]
    public class BaseController : Controller
    {
        
    }
}
