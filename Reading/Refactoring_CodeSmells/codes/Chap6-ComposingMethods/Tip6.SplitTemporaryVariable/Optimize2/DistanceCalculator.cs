namespace Tip6.SplitTemporaryVariable.Optimize2
{
    internal class DistanceCalculator
    {
        public double GetDistanceTravelled(Scenario scenario, int time)
        {
            double distance;
            double primaryAcc = scenario.PrimaryForce / scenario.Mass;
            int primaryTime = Math.Min(time, scenario.Delay);
            distance = 0.5 * primaryAcc * primaryTime * primaryTime;
            int secondaryTime = time - scenario.Delay;
            if (secondaryTime > 0)
            {
                double primarySpeed = primaryAcc * scenario.Delay;
                double secondaryAcc = (scenario.PrimaryForce + scenario.SecondaryForce) / scenario.Mass;
                distance += primarySpeed * secondaryTime + 0.5 * secondaryAcc * secondaryTime * secondaryTime;
            }
            return distance;
        }
    }
}