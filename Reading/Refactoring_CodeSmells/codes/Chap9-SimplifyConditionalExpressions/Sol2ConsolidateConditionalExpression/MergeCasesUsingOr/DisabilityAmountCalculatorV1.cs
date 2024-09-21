namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculatorV1
    {
        internal double GetDisabilityAmount(Employee person)
        {
            if (person.Seniority < 2) return 0;
            if (person.MonthsDisabled > 12) return 0;  // Need report in specific period
            if (person.IsPartTime) return 0;

            // compute the disability amount
            return Compute(person);
        }
         
        private double Compute(Employee person)
        {
            if (person.IsPartTime)
            {
                return 0;
            }

            return 0;
        }
    }
}