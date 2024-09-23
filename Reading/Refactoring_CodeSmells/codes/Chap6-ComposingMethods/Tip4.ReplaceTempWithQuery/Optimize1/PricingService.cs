namespace Tip4.ReplaceTempWithQuery.Optimize1
{
    internal class PricingService
    {
        public double GetTotalPrice(Product product)
        {
            double basePrice = BasePrice(product);
            double discountFactor;
            if (basePrice > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;
            return basePrice * discountFactor;
        }

        private double BasePrice(Product product)
        {
            return product.Quantity * product.ItemPrice;
        }
    }
}