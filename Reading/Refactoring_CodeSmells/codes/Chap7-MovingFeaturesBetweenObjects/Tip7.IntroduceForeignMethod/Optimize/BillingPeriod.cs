namespace Tip7.IntroduceForeignMethod.Optimize
{
    internal class BillingPeriod
    {
        internal DateTime GetNewStartDate()
        {
            DateTime previousEnd = DateTime.Today.AddDays(-1);
            DateTime newStart = NextDay(previousEnd);
            return newStart;
        }

        private static DateTime NextDay(DateTime previousEnd)
            => new DateTime(previousEnd.Year, previousEnd.Month, previousEnd.Day + 1);
    }
}