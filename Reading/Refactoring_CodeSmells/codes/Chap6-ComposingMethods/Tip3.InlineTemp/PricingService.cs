namespace Tip3.InlineTemp
{
    public class PricingService
    {
        public bool CheckPrice(Order order)
        {
            double basePrice = order.BasePrice();
            return basePrice > 1000;
        }
    }
}