namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.EmployeesWithPolymorphism
{
    internal class Engineer : Employee
    {
        public override EmployeeType GetTheType()
        {
            return EmployeeType.Engineer;
        }

        public override double GetCommission()
        {
            throw new NotImplementedException();
        }

        public override double GetMonthlySalary()
        {
            throw new NotImplementedException();
        }

        public override double GetBonus()
        {
            return 0;
        }

        public override double PayAmount()
        {
            return GetMonthlySalary();
        }
    }
}