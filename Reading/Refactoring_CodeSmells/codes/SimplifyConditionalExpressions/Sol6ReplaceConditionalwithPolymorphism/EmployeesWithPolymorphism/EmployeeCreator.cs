namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.EmployeesWithPolymorphism
{
    internal class EmployeeCreator
    {
        internal static Employee Create(EmployeeType type)
        {
            switch (type)
            {
                case EmployeeType.Engineer:
                    return new Engineer();

                case EmployeeType.Salesman:
                    return new Salesman();

                case EmployeeType.Manager:
                    return new Manager();

                default:
                    throw new ArgumentException("Incorrect type value.");
            }
        }
    }
}