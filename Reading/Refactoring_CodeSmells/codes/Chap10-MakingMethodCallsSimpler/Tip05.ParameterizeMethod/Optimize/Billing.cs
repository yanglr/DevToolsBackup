namespace Tip05.ParameterizeMethod.Optimize
{
    internal class Billing
    {
        public Dollars BaseCharge(double usage)
        {
            if (usage < 0)
            {
                return new Dollars(0);
            }

            double amount = WithinBand(usage, 0, 100) * 0.03 + WithinBand(usage, 100, 200) * 0.05
                + WithinBand(usage, 200, double.PositiveInfinity) * 0.07;
            return new Dollars(amount);
        }

        private double WithinBand(double usage, double bottom, double top)
        {
            return usage > bottom ? Math.Min(usage, top) - bottom : 0;
        }

        private double BottomBand(double usage)
        {
            return Math.Min(usage, 100);
        }
    }
}