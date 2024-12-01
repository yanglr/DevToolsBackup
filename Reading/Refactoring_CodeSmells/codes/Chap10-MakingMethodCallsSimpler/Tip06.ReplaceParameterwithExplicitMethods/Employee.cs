namespace Tip06.ReplaceParameterWithExplicitMethods
{
    internal class Employee
    {
        internal static Employee Create(int type)
        {
            switch (type)
            {
                case Constants.Engineer:
                    return new Engineer();

                case Constants.Salesman:
                    return new Salesman();

                case Constants.Manager:
                    return new Manager();

                default:
                    throw new ArgumentException("Incorrect type code value");
            }
        }
    }
}