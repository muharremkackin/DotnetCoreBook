using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

            IProductSelection cart = new Cart(
                new Product { Name = "Kayak", Price = 275M },
                new Product { Name = "Lifejacket", Price = 48.95M },
                new Product { Name = "Soccer ball", Price = 19.50M },
                new Product { Name = "Corner flag", Price = 34.95M }
            );


            return View(cart.Names);
        }

        public async Task<IActionResult> Length()
        {
            long? length = await AsyncExtensions.GetPageLength();
            return View("Index", new string[] { $"Length: {length}" });
        }

        public async Task<IActionResult> Lengths()
        {
            List<string> output = new List<string>();
            await foreach (long? length in AsyncExtensions.GetPageLengths(output, "apress.com", "microsoft.com", "amazon.com"))
            {
                output.Add($"Page length: {length}");
            }
            return View("Index", output);
        }
    }
}