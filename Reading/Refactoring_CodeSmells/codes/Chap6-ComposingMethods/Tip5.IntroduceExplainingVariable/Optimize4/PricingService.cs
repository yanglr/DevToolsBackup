namespace Tip5.IntroduceExplainingVariable.Optimize4
{
    internal class PricingService
    {
        public double GetPrice(Order order)
        {
            double basePrice = order.Quantity * order.ItemPrice;
            double quantityDiscount = Math.Max(0, order.Quantity - 500) *
                order.ItemPrice * 0.05;
            double shipping = Math.Min(basePrice * 0.1, 100);
            return basePrice - quantityDiscount + shipping;
        }
    }
}