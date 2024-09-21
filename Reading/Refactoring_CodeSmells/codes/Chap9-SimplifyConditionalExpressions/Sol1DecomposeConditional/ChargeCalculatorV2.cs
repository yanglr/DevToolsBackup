namespace SimplifyConditionalExpressions.Sol1DecomposeConditional
{
    internal class ChargeCalculatorV2
    {
        internal static double TotalPricesOfGoods(int quantity, double summerPrice,
            double winterPrice, double winterServiceCharge)
        {
            DateTime dateOfNow = DateTime.Now;
            double charge;

            if (NotSummer(dateOfNow))
            {
                charge = NotSummerCharge(quantity, winterPrice, winterServiceCharge);
            }
            else
            {
                charge = SummerCharge(quantity, summerPrice);
            }

            return charge;
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
