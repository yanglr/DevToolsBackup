namespace Tip01.RenameMethod.MigrationMechanics.Step2
{
    internal class TestClient
    {
        public static void Test()
        {
            var person = new Person("021", "58652235");

            var result = person.GetOfficeTelephoneNumber();

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}