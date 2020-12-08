namespace LanguageFeatures.Models
{
    public static class Extensions
    {
        public static decimal TotalPrices(this Cart cart)
        {
            decimal total = 0;
            foreach (Product product in cart.Products)
            {
                total += product?.Price ?? 0;
            }
            return total;
        }
    }
}