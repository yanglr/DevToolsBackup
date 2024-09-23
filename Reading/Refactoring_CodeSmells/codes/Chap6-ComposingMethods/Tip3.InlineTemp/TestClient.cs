namespace Tip3.InlineTemp
{
    internal class TestClient
    {
        public static void Test()
        {
            var priceService = new PricingService();
            double basePrice = 1200;
            var order = new Order(basePrice);
            Console.WriteLine($"Base Price {basePrice} greater than 1000?");
            Console.WriteLine(priceService.CheckPrice(order));
        }
    }
}