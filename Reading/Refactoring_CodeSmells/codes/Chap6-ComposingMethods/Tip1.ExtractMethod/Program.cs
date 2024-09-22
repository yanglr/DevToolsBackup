namespace Tip1.ExtractMethod;

internal class Program
{
    private static void Main(string[] args)
    {
        var printHelper = new PrintHelper();
        var invoice = new Invoice
        {
            CustomerName = "CustomerName 1",
            DueDate = new DateTime(2024, 9, 15),
            Orders = new List<Order> { new Order { Amount = 2 } }
        };

        printHelper.PrintOwing(invoice);
        Console.ReadKey();
    }
}