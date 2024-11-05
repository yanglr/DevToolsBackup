namespace Tip3.ExtractClass
{
    internal class TestClient
    {
        public static void Test()
        {
            var person = new Person("John", "007", "897");

            string result = person.GetTelephoneNumber();

            Console.WriteLine(result);
        }
    }
}