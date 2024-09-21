namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForProjectExpense
{
    internal class TestClient
    {
        public static void Test()
        {
            var employee = new Employee();
            Console.WriteLine(employee.WithinLimit(1, -1));
        }
    }
}