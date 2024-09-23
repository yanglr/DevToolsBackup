namespace Tip3.InlineTemp.Optimize
{
    internal class PricingService
    {
        public bool CheckPrice(Order order)
        {
            return order.BasePrice() > 1000;
        }
    }
}