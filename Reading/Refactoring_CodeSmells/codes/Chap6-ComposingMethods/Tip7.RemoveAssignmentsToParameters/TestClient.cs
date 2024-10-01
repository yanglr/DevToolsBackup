namespace Tip7.RemoveAssignmentsToParameters
{
    internal class TestClient
    {
        public static void Test()
        {
            var service = new PriceService();
            Console.WriteLine(service.GetPrice(24, 120, 2027));
        }
    }
}