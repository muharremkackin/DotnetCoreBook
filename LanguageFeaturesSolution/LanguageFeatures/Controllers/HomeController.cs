using System.Collections.Generic;
using System.Linq;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {

        bool FilterByPrice(Product product, decimal price)
        {
            return (product?.Price ?? 0) >= price;
        }

        bool FilterByName(Product product, string query)
        {
            return (product?.Name?.Contains(query) == true);
        }

        public IActionResult Index()
        {
            var names = new[] { "LOTR", "Matrix", "Golden Compass", "Interstellar", "Cloud Atlas" };
            var products = new[] {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M }
            };

            List<string> results = new List<string>();
            foreach (var product in products)
            {
                results.Add($"Name: {product.Name}, Price: {product.Price}");
            }

            return View(results);
        }
    }
}