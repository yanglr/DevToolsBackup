namespace Tip5.HideDelegate.Optimize
{
    internal class TestClient
    {
        public static void Test()
        {
            var department = new Department("Jack");
            var john = new Person(department);
            string manager = john.GetManager();
            Console.WriteLine("Department manager:" + manager);
        }
    }
}