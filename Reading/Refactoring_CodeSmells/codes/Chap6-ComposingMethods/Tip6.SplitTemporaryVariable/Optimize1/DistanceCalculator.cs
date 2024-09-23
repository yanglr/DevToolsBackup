namespace Tip6.SplitTemporaryVariable.Optimize1
{
    internal class DistanceCalculator
    {
        public double GetDistanceTravelled(Scenario scenario, int time)
        {
            double distance;
            double primaryAcc = scenario.PrimaryForce / scenario.Mass; // acc = F/m
            int primaryTime = Math.Min(time, scenario.Delay);
            distance = 0.5 * primaryAcc * primaryTime * primaryTime; // ds = a*t^2
            int secondaryTime = time - scenario.Delay;
            if (secondaryTime > 0)
            {
                double primarySpeed = primaryAcc * scenario.Delay;  // v = a*t
                double acc = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass; // acc = (F1+F2)/m
                distance += primarySpeed * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }
            return distance;
        }
    }
}