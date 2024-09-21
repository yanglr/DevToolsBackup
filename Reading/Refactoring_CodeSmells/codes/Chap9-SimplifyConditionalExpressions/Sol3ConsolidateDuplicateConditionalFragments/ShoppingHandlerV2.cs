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

            Pack(product);
            return total;
        }

        private static void Pack(Product product)
        {
            Console.WriteLine($"{product.Name} packed.");
        }
    }
}