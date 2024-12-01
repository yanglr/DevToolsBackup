namespace Tip05.ParameterizeMethod
{
    internal class Billing
    {
        public Dollars BaseCharge(double usage)
        {
            if (usage < 0)
            {
                return new Dollars(0);
            }

            double amount = BottomBand(usage) * 0.03 + MiddleBand(usage) * 0.05
                + TopBand(usage) * 0.07;
            return new Dollars(amount);
        }

        private double BottomBand(double usage)
        {
            return Math.Min(usage, 100);
        }

        private double MiddleBand(double usage)
        {
            return usage > 100 ? Math.Min(usage, 200) - 100 : 0;
        }

        private double TopBand(double usage)
        {
            return usage > 200 ? usage - 200 : 0;
        }
    }
}