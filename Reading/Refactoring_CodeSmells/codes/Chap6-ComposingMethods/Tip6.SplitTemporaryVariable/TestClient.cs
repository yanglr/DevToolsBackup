namespace Tip6.SplitTemporaryVariable.Optimize2
{
    internal class TestClient
    {
        public static void Test()
        {
            var scenario = new Scenario { PrimaryForce = 10, SecondaryForce = 5, Delay = 3, Mass = 8 };
            var distanceCalculator = new DistanceCalculator();
            Console.WriteLine(distanceCalculator.GetDistanceTravelled(scenario, 5));
        }
    }
}