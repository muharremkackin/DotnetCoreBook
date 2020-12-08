using System.Collections.Generic;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            object[] data = new object[] { 275M, 29.95M, "apple", "orange", 100, 10 };
            decimal total = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] is decimal d)
                {
                    total += d;
                }
            }
            return View(new string[] { $"Total: {total:C2}" });
        }
    }
}