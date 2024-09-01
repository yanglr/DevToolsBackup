namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.BirdsWithPolymorphism
{
    internal class TestClient
    {
        internal static void Test()
        {
            Bird bird = BirdCreator.Create(BirdType.NorwegianBlue);
            Console.WriteLine(bird.GetFlySpeed(5));
        }
    }
}