namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class TestClient
    {
        internal static void Test()
        {
            Bird bird = new AfricanBird { IsNailed = true, Voltage = 20 };
            Console.WriteLine(bird.GetFlySpeed(5));
        }
    }
}