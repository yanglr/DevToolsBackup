namespace Tip02.AddParameter
{
    internal class TestClient
    {
        public static void Test()
        {
            var book = new Book();
            var customer = new Customer("John", "Zhongshan Road No.123", "0215685632");

            book.AddReservation(customer);

            Console.ReadKey();
        }
    }
}