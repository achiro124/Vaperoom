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

        public async Task<IActionResult> Category(string Category, int Type)
        {
            var Products = await _product.GetByCategory(Category);
            if(Type != -1)
            {
                Products = _product.GetByType(Products,Type);
            }
            else
            {
                Products = _product.Sorting(Products, "ValueOne");
            }
            return View(Products);  
        }
        
    }
}
