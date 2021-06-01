using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vaperoom.Manager.Products;
using Vaperoom.Storage.Entity;

namespace Vaperoom.Controllers
{
    public class HomeController : Controller
    {

        private readonly IProductManager _product;

        public HomeController(IProductManager productManager)
        {
            _product = productManager;
        }

        public async Task<IActionResult> Index()
        {
            var product = await _product.GetAllProductsAsync();
            return View(product);
        }

    }
}
