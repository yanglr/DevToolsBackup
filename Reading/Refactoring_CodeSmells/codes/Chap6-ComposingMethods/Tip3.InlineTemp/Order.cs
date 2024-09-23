namespace Tip3.InlineTemp
{
    public class Order
    {
        private readonly double _basePrice;

        public Order(double basePrice)
        {
            _basePrice = basePrice;
        }

        public double BasePrice()
        {
            return _basePrice;
        }
    }
}