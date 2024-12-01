namespace Tip04.SeparateQueryfromModifier.Step4
{
    internal class TestClient
    {
        public static void Test()
        {
            var nameFinder = new NameFinder();
            var people = new string[] { "John", "Andy", "Kent" };
            nameFinder.CheckSecurity(people);

            Console.ReadKey();
        }
    }
}