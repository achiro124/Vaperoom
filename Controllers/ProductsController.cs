using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Manager.Products;
using Vaperoom.Manager.Users;

namespace Vaperoom.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductManager _product;
        private readonly IUserManager _user;

        public ProductsController(IProductManager productManager, IUserManager userManager)
        {
            _product = productManager;
            _user = userManager;
        }
        public async Task<IActionResult> Product(int ProductId)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            var product = await _product.GetProductById(ProductId);
            ViewBag.Review = _product.UserReview(User.Identity.Name, ProductId);
            ViewBag.User = User.Identity.Name;
            ViewBag.UserId = _user.GetUserId(User.Identity.Name);
            return View(product);
        }

        public async Task<IActionResult> Category(string Category, string Type)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            var Products = await _product.GetByCategory(Category);
            ViewBag.Type = Category;
            if(Type != null && Type != "sort")
            {
                Products = _product.GetByType(Products,int.Parse(Type));
                ViewBag.Type = _product.GetNameTypeProduct(int.Parse(Type));
            }
            if(Type == "sort")
            {
                Products = _product.Sorting(Products, "ValueOne");
                ViewBag.Type = "Топовые цены";
            }
            return View(Products);  
        }

        public async Task<IActionResult> Search(string Name)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            ViewData["Getemployeedetails"] = Name;
            ViewBag.User = User.Identity.Name;
            var media = await _product.Search(Name);
            return View(media);
        }

        [HttpPost]
        public async Task<ActionResult> AddReviews(int ProductId, string text)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            await _product.AddReviews(ProductId, User.Identity.Name, text);
            return RedirectToAction("Product", "Products", new { ProductId });
        }

        public async Task<ActionResult> DeleteReviews(int ProductId, int IdUser)
        {
            ViewBag.CoutBasket = _product.GetCoutBasket(User.Identity.Name);
            await _product.DeleteReviews(ProductId, IdUser);
            return RedirectToAction("Product", "Products", new { ProductId });
        }

        [HttpPost]
        public async Task<ActionResult> EditReviews(int ProductId, string text)
        {
            await _product.EditReviews(ProductId, _user.GetUserId(User.Identity.Name), text);
            return RedirectToAction("Product", "Products", new { ProductId });
        }

    }
}
