namespace Tip1.ExtractMethod
{
    public class PrintHelper
    {
        // Print information of owing amount from customers
        public void PrintOwing(Invoice invoice)
        {
            double outstanding = 0;

            // Print banner
            Console.WriteLine("***********************");
            Console.WriteLine("**** CustomerName Owes ****");
            Console.WriteLine("***********************");

            // calculate outstanding
            foreach (var order in invoice.Orders)
            {
                outstanding += order.Amount;
            }

            // record due date
            DateTime today = DateTime.Today;
            invoice.DueDate = today.AddDays(30);

            // print details
            Console.WriteLine($"name: {invoice.CustomerName}");
            Console.WriteLine($"amount: {outstanding}");
            Console.WriteLine($"due: {invoice.DueDate.ToShortDateString()}");
        }
    }
}