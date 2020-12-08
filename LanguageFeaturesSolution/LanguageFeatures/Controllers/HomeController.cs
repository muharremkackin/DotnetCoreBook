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
            decimal total = cart.TotalPrices();
            return View(new string[] { $"Total: {total:C2}" });
        }
    }
}