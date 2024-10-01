namespace Tip7.RemoveAssignmentsToParameters.Optimzie1
{
    internal class PriceService
    {
        public int GetPrice(int price, int quantity, int yearToDate)
        {
            int result = price;
            if (price > 50) result -= 2;
            if (quantity > 100) result -= 1;
            if (yearToDate > 10000) result -= 4;
            return result;
        }
    }
}