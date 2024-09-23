namespace Tip4.ReplaceTempWithQuery.Optimize2
{
    internal class PricingService
    {
        public double GetTotalPrice(Product product)
        {
            double discountFactor;
            if (BasePrice(product) > 1000) discountFactor = 0.95;
            else discountFactor = 0.98;
            return BasePrice(product) * discountFactor;
        }

        private double BasePrice(Product product)
        {
            return product.Quantity * product.ItemPrice;
        }
    }
}