namespace Tip4.ReplaceTempWithQuery.Optimize4
{
    internal class PricingService
    {
        public double GetTotalPrice(Product product)
        {
            return BasePrice(product) * DiscountFactor(product);
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