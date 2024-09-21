namespace SimplifyConditionalExpressions.Sol1DecomposeConditional
{
    internal class ChargeCalculator
    {
        internal static double TotalPricesOfGoods(int quantity, double summerPrice,
            double winterPrice, double winterServiceCharge)
        {
            DateTime dateOfNow = DateTime.Now;
            return NotSummer(dateOfNow)
                ? NotSummerCharge(quantity, winterPrice, winterServiceCharge)
                : SummerCharge(quantity, summerPrice);
        }

        private static double SummerCharge(int quantity, double summerPrice)
        {
            return quantity * summerPrice;
        }

        private static double NotSummerCharge(int quantity, double winterPrice,
            double winterServiceCharge)
        {
            return quantity * winterPrice + winterServiceCharge;
        }

        private static bool NotSummer(DateTime dateOfNow)
        {
            return dateOfNow < SummerDates.SummerStart || dateOfNow > SummerDates.SummerEnd;
        }
    }
}