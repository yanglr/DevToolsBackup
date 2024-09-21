namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.BirdsWithPolymorphism
{
    internal class TestClient
    {
        internal static void Test()
        {
            Bird bird = BirdCreator.Create(BirdType.NorwegianBlueParrot);
            //Console.WriteLine(bird.GetFlySpeed(5));
        }
    }
}