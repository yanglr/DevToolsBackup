namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalWithGuardClauses.UsingReturn
{
    internal class SalaryCalculatorV2
    {
        internal double GetPayAmount(EmployeeStatus status)
        {
            double result;
            if (status == EmployeeStatus.Dead) return DeadAmount();
            if (status == EmployeeStatus.Separated) result = SeparatedAmount();
            else
            {
                if (status == EmployeeStatus.Retired) result = RetiredAmount();
                else
                {
                    result = NormalPayAmount();
                }
            };

            return result;
        }

        private double NormalPayAmount()
        {
            throw new NotImplementedException();
        }

        private double RetiredAmount()
        {
            throw new NotImplementedException();
        }

        private double SeparatedAmount()
        {
            throw new NotImplementedException();
        }

        private double DeadAmount()
        {
            throw new NotImplementedException();
        }
    }
}
