namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalWithPolymorphism.EmployeesWithPolymorphism
{
    internal class Manager : Employee
    {
        public override double GetBonus()
        {
            throw new NotImplementedException();
        }

        public override double GetCommission()
        {
            throw new NotImplementedException();
        }

        public override double GetMonthlySalary()
        {
            throw new NotImplementedException();
        }

        public override EmployeeType GetTheType()
        {
            return EmployeeType.Manager;
        }

        public override double PayAmount()
        {
            return GetMonthlySalary() + GetBonus();
        }
    }
}