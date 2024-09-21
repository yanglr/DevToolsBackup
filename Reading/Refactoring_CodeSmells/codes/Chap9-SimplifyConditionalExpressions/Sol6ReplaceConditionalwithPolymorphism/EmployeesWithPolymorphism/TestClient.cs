namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.EmployeesWithPolymorphism
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