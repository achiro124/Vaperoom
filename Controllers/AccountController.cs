using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;
using Vaperoom.Manager.Accounts;
using Vaperoom.Manager.Products;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Controllers
{
    public class AccountController : Controller
    {
        private IAccountManager db;
        private IProductManager _product;
        public AccountController(IAccountManager accountManager, IProductManager productManager)
        {
            db = accountManager;
            _product = productManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel model)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            if (ModelState.IsValid)
            {
                var user = await db.GetUser(model);
                if (user != null)
                {
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                ModelState.AddModelError("", "Некорректные email и(или) пароль");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            if (ModelState.IsValid)
            {
                var user = await db.GetUser1(model);
                if (user == null)
                {
                    await db.AddUsers(model);
                    await Authenticate(model.Email); // аутентификация

                    return RedirectToAction("Index", "Home");
                }
                else
                    ModelState.AddModelError("", "Некорректные email и(или) пароль");
            }
            return View(model);
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Login", "Account");
        }

       private async Task Authenticate(string userName)
       {
           // создаем один claim
           var claims = new List<Claim>
           {
               new Claim(ClaimsIdentity.DefaultNameClaimType, userName)
           };
           // создаем объект ClaimsIdentity
           ClaimsIdentity id = new ClaimsIdentity(claims, "ApplicationCookie", ClaimsIdentity.DefaultNameClaimType, ClaimsIdentity.DefaultRoleClaimType);
           // установка аутентификационных куки
           await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(id));
       }
    }
}
