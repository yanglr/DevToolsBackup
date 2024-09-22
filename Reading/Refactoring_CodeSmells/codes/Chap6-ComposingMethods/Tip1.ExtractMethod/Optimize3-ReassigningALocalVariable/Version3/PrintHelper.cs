namespace Tip1.ExtractMethod.Optimize3.Version3
{
    public class PrintHelper
    {
        public void PrintOwing(Invoice invoice)
        {
            PrintBanner();
            double outstanding = CalculateOutstanding(invoice);
            RecordDueDate(invoice);
            PrintDetails(invoice, outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private double CalculateOutstanding(Invoice invoice)
        {
            double result = 0;
            foreach (var order in invoice.Orders)
            {
                result += order.Amount;
            }
            return result;
        }

        private void RecordDueDate(Invoice invoice)
        {
            DateTime today = DateTime.Today;
            invoice.DueDate = today.AddDays(30);
        }

        private void PrintDetails(Invoice invoice, double outstanding)
        {
            Console.WriteLine($"name: {invoice.CustomerName}");
            Console.WriteLine($"amount: {outstanding}");
            Console.WriteLine($"due: {invoice.DueDate.ToShortDateString()}");
        }
    }
}