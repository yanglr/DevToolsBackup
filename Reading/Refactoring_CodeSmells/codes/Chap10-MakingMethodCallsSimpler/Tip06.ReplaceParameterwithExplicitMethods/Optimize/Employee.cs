namespace Tip06.ReplaceParameterWithExplicitMethods.Optimize
{
    internal class Employee
    {
        internal static Employee CreateEngineer()
        {
            return new Engineer();
        }

        internal static Employee CreateSalesman()
        {
            return new Salesman();
        }

        internal static Employee CreateManager()
        {
            return new Manager();
        }

        private static Employee Create(int type)
        {
            switch (type)
            {
                case Constants.Engineer:
                    return CreateEngineer();

                case Constants.Salesman:
                    return CreateSalesman();

                case Constants.Manager:
                    return CreateManager();

                default:
                    throw new ArgumentException("Incorrect type code value");
            }
        }
    }
}