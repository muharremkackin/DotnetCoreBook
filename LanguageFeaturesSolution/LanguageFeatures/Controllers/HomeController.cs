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
                string related = product?.Related?.Name ?? "<None>";
                string category = product?.Category ?? "<No Category>";
                results.Add(string.Format($"Name: {name}, Price: {price}, Related: {related}, Category: {category}"));
            }
            return View(results);
        }
    }
}