using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Cart cart = new Cart { Products = Product.GetProducts() };
            IEnumerable<Product> products = Product.GetProducts();
            decimal cartTotal = cart.TotalPrices();
            decimal ProductsTotal = products.TotalPrices();
            return View(new string[] { $"Total: {cartTotal:C2}", $"Total: {cartTotal:C2}", });
        }
    }
}