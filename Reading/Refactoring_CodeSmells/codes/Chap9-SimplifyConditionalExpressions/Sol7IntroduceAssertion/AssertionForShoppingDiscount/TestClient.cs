namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForShoppingDiscount
{
    internal class TestClient
    {
        public static void Test()
        {
            var customer = new CustomerV2();
            Console.WriteLine(customer.ApplyDiscount(100, 2));
            // Console.WriteLine(customer.ApplyDiscount(100, 0.2));
        }
    }
}