namespace SimplifyConditionalExpressions.Sol6ReplaceConditionalwithPolymorphism.EmployeesWithPolymorphism
{
    internal class Salesman : Employee
    {
        public override EmployeeType GetTheType()
        {
            return EmployeeType.Salesman;
        }

        public override double GetMonthlySalary()
        {
            throw new NotImplementedException();
        }

        public override double GetBonus()
        {
            throw new NotImplementedException();
        }

        public override double GetCommission()
        {
            throw new NotImplementedException();
        }

        public override double PayAmount()
        {
            return GetMonthlySalary() + GetCommission();
        }
    }
}