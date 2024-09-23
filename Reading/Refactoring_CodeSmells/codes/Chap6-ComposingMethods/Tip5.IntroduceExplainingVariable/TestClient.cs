using Tip5.IntroduceExplainingVariable;

namespace Tip4.ReplaceTempWithQuery.Optimize5
{
    internal class TestClient
    {
        public static void Test()
        {
            var priceService = new PricingService();
            var order = new Order { ItemPrice = 7.5, Quantity = 20 };
            Console.WriteLine(priceService.GetPrice(order));
        }
    }
}