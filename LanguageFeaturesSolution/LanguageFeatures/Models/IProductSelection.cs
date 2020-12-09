using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public interface IProductSelection
    {
        IEnumerable<Product> Products { get; }
    }
}