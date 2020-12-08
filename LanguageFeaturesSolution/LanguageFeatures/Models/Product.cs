using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool stock = true)
        {
            InStock = stock;
        }
        public string Name { get; set; }
        public string Category { get; set; } = "Watersports";
        public decimal? Price { get; set; }
        public Product Related { get; set; }
        public bool InStock { get; }

        public static List<Product> GetProducts()
        {
            List<Product> products = new List<Product>() {
                new Product {Name = "Charger and Cable", Category = "Technology", Price = 123M},
                new Product {Name = "iPhone 11", Category = "Technology", Price = 432M},
                new Product {Name = "iPad Pro 12", Price = 2543M},
                new Product {Name = "Stickers", Price = 34M},
                new Product {Name = "Macbook Pro 2020", Price = 4353M},
                null,
                null
            };

            products[0].Related = products[1];
            products[1].Related = products[2];
            products[2].Related = products[3];

            return products;
        }
    }
}