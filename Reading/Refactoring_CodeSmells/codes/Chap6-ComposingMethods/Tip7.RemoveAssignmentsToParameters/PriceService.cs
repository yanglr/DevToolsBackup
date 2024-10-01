namespace Tip7.RemoveAssignmentsToParameters
{
    internal class PriceService
    {
        public int GetPrice(int price, int quantity, int yearToDate)
        {
            if (price > 50) price -= 2;
            if (quantity > 100) price -= 1;
            if (yearToDate > 10000) price -= 4;
            return price;
        }
    }
}