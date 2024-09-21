namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculatorV2
    {
        internal double GetDisabilityAmount(Employee person)
        {
            if (person.Seniority < 2 || person.MonthsDisabled > 12 || person.IsPartTime)
            {
                return 0;
            }

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