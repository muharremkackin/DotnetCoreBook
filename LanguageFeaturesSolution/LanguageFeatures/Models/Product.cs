using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>() {
                new Product {Name = "Charger and Cable", Price = 123M},
                new Product {Name = "iPhone 11", Price = 432M},
                new Product {Name = "iPad Pro 12", Price = 2543M},
                new Product {Name = "Stickers", Price = 34M},
                new Product {Name = "Macbook Pro 2020", Price = 4353M},
                null,
                null
            };

            return products;
        }
    }
}