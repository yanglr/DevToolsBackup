namespace Tip4.ReplaceTempWithQuery
{
    public class PricingService
    {
        public double GetTotalPrice(Product product)
        {
            double basePrice = product.Quantity * product.ItemPrice;
            double discountFactor;
            if (basePrice > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;
            return basePrice * discountFactor;
        }
    }
}