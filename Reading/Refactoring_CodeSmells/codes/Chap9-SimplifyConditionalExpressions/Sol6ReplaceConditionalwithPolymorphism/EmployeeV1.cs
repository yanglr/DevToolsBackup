using SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.EmployeesWithPolymorphism;

namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism
{
    internal class EmployeeV1
    {
        private EmployeeType _type;
        private double _monthlySalary = 0;
        private double _commission = 0;
        private double _bonus = 0;

        public EmployeeType EmployeeType
        {
            get { return _type; }
            set { _type = value; }
        }

        internal double PayAmount()
        {
            switch (_type)
            {
                case EmployeeType.Engineer:
                    return _monthlySalary;

                case EmployeeType.Salesman:
                    return _monthlySalary + _commission;

                case EmployeeType.Manager:
                    return _monthlySalary + _bonus;

                default:
                    throw new InvalidOperationException("Not supportted Employee type.");
            }
        }

        // public abstract EmployeeType GetTheType();
    }
}