namespace Tip06.ReplaceParameterWithExplicitMethods
{
    internal class TestClient
    {
        public static void Test()
        {
            Employee kent = Employee.Create(Constants.Engineer);

            Console.ReadKey();
        }
    }
}