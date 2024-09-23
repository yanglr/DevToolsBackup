namespace Tip6.SplitTemporaryVariable
{
    internal class DistanceCalculator
    {
        public double GetDistanceTravelled(Scenario scenario, int time)
        {
            double distance;
            double acc = scenario.PrimaryForce / scenario.Mass; // acceleration = F/m based on Newton's rule
            int primaryTime = Math.Min(time, scenario.Delay);
            distance = 0.5 * acc * primaryTime * primaryTime;  // ds = a*t^2
            int secondaryTime = time - scenario.Delay;
            if (secondaryTime > 0)
            {
                double primarySpeed = acc * scenario.Delay;  // v = a*t
                acc = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass; // acc = (F1+F2)/m
                distance += primarySpeed * secondaryTime + 0.5 * acc * secondaryTime * secondaryTime;
            }
            return distance;
        }
    }
}