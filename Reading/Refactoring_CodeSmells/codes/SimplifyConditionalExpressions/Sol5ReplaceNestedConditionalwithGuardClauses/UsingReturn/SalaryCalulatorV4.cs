using SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalwithGuardClauses.UsingReturn;

namespace SimplifyConditionalExpressions.Sol5ReplaceNestedConditionalwithGuardClauses
{
    internal class SalaryCalulatorV4
    {
        internal double GetPayAmount(EmployeeStatus status)
        {
            if (status == EmployeeStatus.Dead) return DeadAmount();
            if (status == EmployeeStatus.Separated) return SeparatedAmount();
            if (status == EmployeeStatus.Retired) return RetiredAmount();
            return NormalPayAmount();
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