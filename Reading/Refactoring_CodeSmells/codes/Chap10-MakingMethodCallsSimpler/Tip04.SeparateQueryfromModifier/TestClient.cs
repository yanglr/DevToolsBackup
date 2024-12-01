namespace Tip04.SeparateQueryfromModifier
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