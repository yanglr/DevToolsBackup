namespace Tip2.InlineMethod.Example2
{
    public class CustomerReportService
    {
        public List<Tuple<string, string>> ReportLines(Customer customer)
        {
            var lines = new List<Tuple<string, string>>();

            GatherCustomerData(lines, customer);

            return lines;
        }

        private void GatherCustomerData(List<Tuple<string, string>> outList, Customer customer)
        {
            outList.Add(Tuple.Create("name", customer.Name));
            outList.Add(Tuple.Create("location", customer.Location));
        }
    }
}