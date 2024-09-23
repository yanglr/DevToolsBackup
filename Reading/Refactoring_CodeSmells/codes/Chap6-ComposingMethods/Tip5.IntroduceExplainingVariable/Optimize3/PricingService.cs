namespace Tip5.IntroduceExplainingVariable.Optimize3
{
    internal class PricingService
    {
        public double GetPrice(Order order)
        {
            // price is base price - quantity discount + shipping
            double basePrice = order.Quantity * order.ItemPrice;
            double quantityDiscount = Math.Max(0, order.Quantity - 500) * order.ItemPrice * 0.05;
            return basePrice - quantityDiscount + Math.Min(basePrice * 0.1, 100);
        }
    }
}