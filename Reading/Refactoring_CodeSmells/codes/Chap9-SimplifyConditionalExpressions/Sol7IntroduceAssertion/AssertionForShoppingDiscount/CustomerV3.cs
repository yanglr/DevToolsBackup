using System.Diagnostics;

namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion.AssertionForShoppingDiscount
{
    internal class CustomerV3
    {
        internal double ApplyDiscount(double totalAmount, double discountRate)
        {
            return totalAmount - (totalAmount * GetDiscountRate(discountRate));
        }

        internal double GetDiscountRate(double discountRate)
        {
            Trace.Assert(discountRate >= 0 && discountRate <= 1);
            return discountRate;
        }
    }
}