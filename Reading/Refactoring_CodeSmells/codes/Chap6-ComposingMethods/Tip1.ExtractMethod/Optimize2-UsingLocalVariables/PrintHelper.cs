﻿namespace Tip1.ExtractMethod.Optimize2
{
    public class PrintHelper
    {
        public void PrintOwing(Invoice invoice)
        {
            double outstanding = 0;
            PrintBanner();

            // calculate outstanding
            foreach (var order in invoice.Orders)
            {
                outstanding += order.Amount;
            }

            // record due date
            DateTime today = DateTime.Today;
            invoice.DueDate = today.AddDays(30);

            // print details
            PrintDetails(invoice, outstanding);
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }

        private void PrintDetails(Invoice invoice, double outstanding)
        {
            Console.WriteLine($"name: {invoice.CustomerName}");
            Console.WriteLine($"amount: {outstanding}");
            Console.WriteLine($"due: {invoice.DueDate.ToShortDateString()}");
        }
    }
}