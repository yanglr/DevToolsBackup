namespace SimplifyConditionalExpressions.Sol3ConsolidateDuplicateConditionalFragments
{
    internal class ShoppingHandler
    {
        internal static double CheckOut(Product product)
        {
            var total = product.Price * (product.IsSpecialDeal ? 0.95 : 0.98);
            Pack(product);
            return total;
        }

        private static void Pack(Product product)
        {
            Console.WriteLine($"{product.Name} packed.");
        }
    }
}