namespace SimplifyConditionalExpressions.Sol7IntroduceAssertion
{
    internal class CustomerV1
    {
        internal double ApplyDiscount(double totalAmount, double discountRate)
        {
            return discountRate >= 0 && discountRate <= 1
              ? totalAmount - totalAmount * discountRate
              : totalAmount;
        }
    }
}