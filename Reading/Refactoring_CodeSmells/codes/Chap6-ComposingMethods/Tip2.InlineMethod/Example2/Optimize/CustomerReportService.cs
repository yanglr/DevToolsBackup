namespace Tip2.InlineMethod.Example2.Optimize
{
    public class CustomerReportService
    {
        public List<Tuple<string, string>> ReportLines(Customer customer)
        {
            return new List<Tuple<string, string>>
            {
                Tuple.Create("name", customer.Name),
                Tuple.Create("location", customer.Location)
            };
        }
    }
}