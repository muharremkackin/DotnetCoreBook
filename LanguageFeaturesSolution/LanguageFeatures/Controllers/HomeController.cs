using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Dictionary<string, Product> products = new Dictionary<string, Product>
            {
                { "macbook-pro-2020", new Product {Name = "Macbook Pro 2020", Price = 3000M} },
                { "ipad-pro-12", new Product {Name = "iPad Pro 12", Price = 1000M} },
            };
            return View(products.Keys);
        }
    }
}