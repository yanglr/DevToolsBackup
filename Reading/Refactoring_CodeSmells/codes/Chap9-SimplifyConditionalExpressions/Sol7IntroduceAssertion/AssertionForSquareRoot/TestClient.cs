namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForSquareRoot
{
    internal class TestClient
    {
        public static void Test()
        {
            var calculator = new Optimize.SquareRootCalculator();
            Console.WriteLine(calculator.GetSquareRoot(-5));
        }
    }
}
