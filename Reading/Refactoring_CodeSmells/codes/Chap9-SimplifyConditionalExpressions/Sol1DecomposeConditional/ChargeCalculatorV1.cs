namespace SimplifyConditionalExpressions.Sol1DecomposeConditional
{
    internal class ChargeCalculatorV1
    {
        internal static double TotalPricesOfGoods(int quantity, double summerPrice,
            double winterPrice, double winterServiceCharge)
        {
            DateTime dateOfNow = DateTime.Now;
            double charge;
            if (dateOfNow < SummerDates.SummerStart || dateOfNow > SummerDates.SummerEnd)
            {
                charge = quantity * winterPrice + winterServiceCharge;
            }
            else
            {
                charge = quantity * summerPrice;
            }

            return charge;
        }
    }
}