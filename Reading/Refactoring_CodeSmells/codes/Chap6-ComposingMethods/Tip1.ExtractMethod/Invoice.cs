namespace Tip1.ExtractMethod
{
    public class Invoice
    {
        public string CustomerName { get; set; }
        public List<Order> Orders { get; set; }
        public DateTime DueDate { get; set; }
    }
}