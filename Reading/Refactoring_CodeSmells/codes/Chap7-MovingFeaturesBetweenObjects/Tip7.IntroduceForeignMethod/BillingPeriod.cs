namespace Tip7.IntroduceForeignMethod
{
    internal class BillingPeriod
    {
        internal DateTime GetNewStartDate()
        {
            DateTime previousEnd = DateTime.Today.AddDays(-1);
            DateTime newStart = new DateTime(previousEnd.Year, previousEnd.Month,
                previousEnd.Day + 1);
            return newStart;
        }
    }
}