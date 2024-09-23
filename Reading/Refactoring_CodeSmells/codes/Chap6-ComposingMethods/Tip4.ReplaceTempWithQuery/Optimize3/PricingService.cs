namespace Tip4.ReplaceTempWithQuery.Optimize3
{
    internal class PricingService
    {
        public double GetTotalPrice(Product product)
        {
            double discountFactor = DiscountFactor(product);
            return BasePrice(product) * discountFactor;
        }

        private double DiscountFactor(Product product)
        {
            if (BasePrice(product) > 1000) return 0.95;
            else return 0.98;
        }

        private double BasePrice(Product product)
        {
            return product.Quantity * product.ItemPrice;
        }
    }
}