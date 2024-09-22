namespace Tip1.ExtractMethod.Optimize3.Version2
{
    public class PrintHelper
    {
        public void PrintOwing(Invoice invoice)
        {
            PrintBanner();

            // calculate outstanding
            double outstanding = 0;  // Move close to usage
            foreach (var order in invoice.Orders)
            {
                outstanding += order.Amount;
            }

            RecordDueDate(invoice);
            PrintDetails(invoice, outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
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