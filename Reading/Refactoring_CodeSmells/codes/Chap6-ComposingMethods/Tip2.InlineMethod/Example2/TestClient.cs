namespace Tip2.InlineMethod.Example2
{
    internal class TestClient
    {
        public static void Test()
        {
            var reportService = new CustomerReportService();
            var customer = new Customer { Name = "Customer123", Location = "Century Avenue No.8" };
            reportService.ReportLines(customer);
        }
    }
}