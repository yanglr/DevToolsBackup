namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculatorV3
    {
        // Note: use logical or (||)
        internal double GetDisabilityAmount(Employee person)
        {
            double disabilityAmount = 0;
            if (IsNotEligibleForDisability(person))
            {
                return 0;
            }

            // compute the disability amount
            return disabilityAmount;
        }

        private static bool IsNotEligibleForDisability(Employee person)
        {
            return person.Seniority < 2 || person.MonthsDisabled > 12 || person.IsPartTime;
        }
    }
}