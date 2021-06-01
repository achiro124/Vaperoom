using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Manager.Products;
using Vaperoom.Manager.Users;

namespace Vaperoom.Controllers
{
    public class UsersController : Controller
    {
        private IUserManager _user;
        private IProductManager _product;
        public UsersController(IUserManager userManager, IProductManager productManager)
        {
            _user = userManager;
            _product = productManager;
        }

        [Authorize]
        public async Task<IActionResult> Profile()
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            if (_user.ImageNull(User.Identity.Name) == false)
                ViewBag.Image = _user.GetImage(User.Identity.Name);
            ViewBag.AllPrice = _user.GetAllPrice(User.Identity.Name);
            var user = await _user.GetUser(User.Identity.Name);
            user.Basket.NumProduct = _user.GetNumberProduct(user.Basket.BasketId);
            return View(user);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> AddInBasket(int ProductId, int hidden)
        {
            await _user.AddInBasket(User.Identity.Name, ProductId, hidden);
            return RedirectToAction("Profile", "Users");
        }

        public async Task<IActionResult> DeleteProductByBasket(int ProductId, int BasketId)
        {
            await _user.DeleteProductByBasket(ProductId, BasketId);
            return RedirectToAction("Profile", "Users");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteAllBasket(int BasketId)
        {
            await _user.DeleteAllBasket(BasketId);
            return RedirectToAction("Profile", "Users");
        }

        [HttpPost]
        public async Task<ActionResult> EditAccount(IFormFile mainPhoto, string name, DateTime DataB)
        {
            await _user.EditAccount(mainPhoto, name, DataB, User.Identity.Name);
            return RedirectToAction("Profile", "Users");
        }
    }
}
