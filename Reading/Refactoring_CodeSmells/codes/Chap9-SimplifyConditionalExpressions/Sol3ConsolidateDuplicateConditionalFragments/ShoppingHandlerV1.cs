namespace SimplifyConditionalExpressions.Sol3ConsolidateDuplicateConditionalFragments
{
    internal class ShoppingHandlerV1
    {
        // Cashier to check out
        internal static double CheckOut(Product product)
        {
            double total;
            if (product.IsSpecialDeal)
            {
                total = product.Price * 0.95;
                Pack(product);
            }
            else
            {
                total = product.Price * 0.98;
                Pack(product);
            }

            return total;
        }

        private static void Pack(Product product)
        {
            Console.WriteLine($"{product.Name} packed.");
        }
    }
}