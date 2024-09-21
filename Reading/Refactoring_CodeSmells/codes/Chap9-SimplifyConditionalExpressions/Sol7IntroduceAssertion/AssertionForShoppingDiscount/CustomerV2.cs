using System.Diagnostics;

namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForShoppingDiscount
{
    internal class Customer
    {
        internal double ApplyDiscount(double totalAmount, double discountRate)
        {
            Trace.Assert(discountRate >= 0 && discountRate <= 1);
            return totalAmount - totalAmount * discountRate;
        }
    }
}
