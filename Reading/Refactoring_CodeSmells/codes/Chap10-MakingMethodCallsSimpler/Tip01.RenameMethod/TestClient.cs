namespace Tip01.RenameMethod
{
    internal class TestClient
    {
        public static void Test()
        {
            var person = new Person("021", "58652235");

            var result = person.GetTelephoneNumber();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}