namespace Tip4.ReplaceTempWithQuery.Optimize4
{
    internal class TestClient
    {
        public static void Test()
        {
            var priceService = new PricingService();
            var product = new Product { ItemPrice = 7.5, Quantity = 20 };
            Console.WriteLine(priceService.GetTotalPrice(product));
        }
    }
}