using SimplifyConditionalExpressions.Sol3;

namespace SimplifyConditionalExpressions.Sol3ConsolidateDuplicateConditionalFragments
{
    internal class ShoppingHandlerV2
    {
        internal static double CheckOut(Product product)
        {
            double total;
            if (product.IsSpecialDeal)
            {
                total = product.Price * 0.95;
            }
            else
            {
                total = product.Price * 0.98;
            }

            Pack();
            return total;
        }

        private static void Pack()
        {
            throw new NotImplementedException();
        }
    }
}