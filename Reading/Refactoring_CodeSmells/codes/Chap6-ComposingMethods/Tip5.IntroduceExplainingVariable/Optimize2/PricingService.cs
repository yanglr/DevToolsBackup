namespace Tip5.IntroduceExplainingVariable.Optimize2
{
    internal class PricingService
    {
        public double GetPrice(Order order)
        {
            // price is base price - quantity discount + shipping
            double basePrice = order.Quantity * order.ItemPrice;
            return basePrice -
                   Math.Max(0, order.Quantity - 500) * order.ItemPrice * 0.05 +
                   Math.Min(basePrice * 0.1, 100);
        }
    }
}