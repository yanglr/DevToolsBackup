namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.EmployeesWithPolymorphism
{
    internal abstract class Employee
    {
        private EmployeeType _type;

        public EmployeeType EmployeeType
        {
            get { return _type; }
            set { _type = value; }
        }

        public abstract double PayAmount();

        public abstract double GetMonthlySalary();
        public abstract double GetCommission();
        public abstract double GetBonus();

        public abstract EmployeeType GetTheType();
    }
}