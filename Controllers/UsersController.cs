using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Manager.Users;

namespace Vaperoom.Controllers
{
    public class UsersController : Controller
    {
        private IUserManager _user;
        public UsersController(IUserManager userManager)
        {
            _user = userManager;
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            if (_user.ImageNull(User.Identity.Name) == false)
                ViewBag.Image = _user.GetImage(User.Identity.Name);
            var user = await _user.GetUser(User.Identity.Name);
            return View(user);
        }

        [Authorize]
        public async Task<IActionResult> AddInBasket(int ProductId, int hidden)
       {
            await _user.AddInBasket(User.Identity.Name, ProductId, hidden);
            return RedirectToAction("Profile", "User");
       }
    }
}
