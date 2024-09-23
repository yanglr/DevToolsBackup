﻿namespace Tip1.ExtractMethod.Optimize1
{
    public class PrintHelper
    {
        public void PrintOwing(Invoice invoice)
        {
            double totalOwingAmount = 0;
            PrintBanner();

            // calculate outstanding
            foreach (var order in invoice.Orders)
            {
                totalOwingAmount += order.Amount;
            }

            // record due date
            DateTime today = DateTime.Today;
            invoice.DueDate = today.AddDays(30);

            // print details
            Console.WriteLine($"name: {invoice.CustomerName}");
            Console.WriteLine($"amount: {totalOwingAmount}");
            Console.WriteLine($"due: {invoice.DueDate.ToShortDateString()}");
        }

        private void PrintBanner()
        {
            Console.WriteLine("***********************");
            Console.WriteLine("**** Customer Owes ****");
            Console.WriteLine("***********************");
        }
    }
}