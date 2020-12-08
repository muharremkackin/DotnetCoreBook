using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class Cart
    {
        public IEnumerable<Product> Products { get; set; }
    }
}