namespace Tip6.RemoveMiddleMan.Optimize
{
    internal class TestClient
    {
        public static void Test()
        {
            var department = new Department("Jack");
            var john = new Person(department);
            string manager = john.GetDepartment().GetManager();
            Console.WriteLine("Department manager:" + manager);
        }
    }
}