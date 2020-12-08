using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public static class Extensions
    {
        public static decimal TotalPrices(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product product in products)
            {
                total += product?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> products, decimal minPrice)
        {
            foreach (Product product in products)
            {
                if ((product?.Price ?? 0) >= minPrice)
                {
                    yield return product;
                }
            }
        }

        public static IEnumerable<Product> FilterByName(this IEnumerable<Product> products, string query)
        {
            foreach (Product product in products)
            {
                if (product?.Name?.Contains(query) == true)
                {
                    yield return product;
                }
            }
        }
    }
}