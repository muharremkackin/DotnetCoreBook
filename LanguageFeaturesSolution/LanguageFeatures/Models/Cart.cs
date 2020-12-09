using System.Collections;
using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class Cart : IProductSelection
    {
        private List<Product> _products = new List<Product>();

        public Cart(params Product[] products)
        {
            _products.AddRange(products);
        }

        public IEnumerable<Product> Products { get => _products; }
    }
}