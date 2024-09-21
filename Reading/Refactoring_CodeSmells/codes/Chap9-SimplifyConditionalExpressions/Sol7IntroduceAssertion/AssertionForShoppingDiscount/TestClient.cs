namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForShoppingDiscount
{
    internal class TestClient
    {
        public static void Test()
        {
            var customer = new Customer();
            Console.WriteLine(customer.ApplyDiscount(100, 2));
        }
    }
}