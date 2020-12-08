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
    }
}