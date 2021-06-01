using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Manager.Products;

namespace Vaperoom.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IProductManager _product;

        public ProductsController(IProductManager productManager)
        {
            _product = productManager;
        }
        public async Task<IActionResult> Product(int ProductId)
        {
            var product = await _product.GetProductById(ProductId);
            return View(product);
        }

        public async Task<IActionResult> Category(string Category, string Type)
        {
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
            ViewData["Getemployeedetails"] = Name;
            ViewBag.User = User.Identity.Name;
            var media = await _product.Search(Name);
            return View(media);
        }

    }
}
