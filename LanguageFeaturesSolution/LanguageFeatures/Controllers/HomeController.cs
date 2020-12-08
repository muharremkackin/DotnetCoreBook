using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<string> results = new List<string>();

            foreach (Product product in Product.GetProducts())
            {
                string name = product?.Name ?? "<No Name>";
                decimal? price = product?.Price ?? 0;
                results.Add(string.Format("Name: {0}, Price: {1}", name, price));
            }
            return View(results);
        }
    }
}