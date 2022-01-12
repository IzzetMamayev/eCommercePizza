using eCommercePizza.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using webUI.Helpers;
using webUI.Interfaces;

namespace webUI.Controllers
{
    public class BaseController : Controller
    {
        //protected UserManager<User> _userManager;
        //public BaseController(UserManager<User> userManager)
        //{
        //    _userManager = userManager;
        //}
        //public User CurrentUser { 

        //    get
        //    {
        //        if (User.Identity.Name != null)
        //        {
        //            return _userManager.FindByNameAsync(User.Identity.Name).Result;
        //        }
        //        else
        //        {
        //            return null;
        //        }
        //    }
        //}

        public User CurrentUser
        {
            get
            {
                if (User.Identity.Name != null)
                {
                    return _userAccessor.GetUser();
                }
                else
                {
                    return null;
                }
            }
        }

        IUserAccessor _userAccessor;
        public BaseController(IUserAccessor userAccessor)
        {
            _userAccessor = userAccessor;
        }
    }
}
