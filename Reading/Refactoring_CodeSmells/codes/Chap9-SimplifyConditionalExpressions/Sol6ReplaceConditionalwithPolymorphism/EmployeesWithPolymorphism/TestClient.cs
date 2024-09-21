namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.EmployeesWithPolymorphism
{
    internal class TestClient
    {
        internal static void Test()
        {
            Employee employee = EmployeeCreator.Create(EmployeeType.Salesman);
            Console.WriteLine(employee.PayAmount());
        }
    }
}