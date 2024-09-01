using SimplifyConditionalExpressions.Sol1DecomposeConditional;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism;
using SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.BirdsWithPolymorphism;

namespace SimplifyConditionalExpressions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //double totalPay = ChargeCalculatorV2.TotalPricesOfGoods(5, 3.5, 3.2, 2);

            //// Result is 18
            //Console.WriteLine($"Total pay should be: {totalPay}");

            // To test bird
            // TestClient.Test();

            // To test Assertion for Project Expense
            // Sol7IntroduceAssertion.AssertionForProjectExpense.TestClient.Test();

            // To test Assertion for Shopping Discount
            Sol7IntroduceAssertion.AssertionForShoppingDiscount.TestClient.Test();
        }
    }
}