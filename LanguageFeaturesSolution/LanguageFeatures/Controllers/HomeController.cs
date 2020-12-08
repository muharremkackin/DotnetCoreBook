using System.Collections.Generic;
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
            Cart cart = new Cart { Products = Product.GetProducts() };
            IEnumerable<Product> products = Product.GetProducts();
            decimal cartTotal = cart.TotalPrices();
            decimal ProductsTotal = products.TotalPrices();
            decimal Filtered = products.FilterByPrice(200).TotalPrices();
            decimal FilteredByName = products.FilterByName("iP").TotalPrices();
            decimal priceFilterTotal = products.Filter(product => FilterByPrice(product, 200)).TotalPrices();
            decimal nameFilterTotal = products.Filter(product => FilterByName(product, "iP")).TotalPrices();
            return View(new string[] {
                $"Total: {cartTotal:C2}",
                $"Total: {cartTotal:C2}",
                $"Filtered by price: {Filtered:C2}",
                $"Filtered by price: {priceFilterTotal:C2}",
                $"Filtered by name: {FilteredByName:C2}",
                $"Filtered by name: {nameFilterTotal:C2}",
                });
        }
    }
}