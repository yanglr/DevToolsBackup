namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculatorV2
    {
        internal double GetDisabilityAmount(Employee person)
        {
            double disabilityAmount = 0;
            if (person.Seniority < 2 || person.MonthsDisabled > 12 || person.IsPartTime)
            {
                return 0;
            }

            // compute the disability amount
            return disabilityAmount;
        }
    }
}