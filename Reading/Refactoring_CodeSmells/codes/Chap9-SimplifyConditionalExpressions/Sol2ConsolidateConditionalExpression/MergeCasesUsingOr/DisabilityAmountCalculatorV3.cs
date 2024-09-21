namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculator
    {
        internal double GetDisabilityAmount(Employee person)
        {
            if (IsNotEligibleForDisability(person))
            {
                return 0;
            }

            // compute the disability amount
            return Compute(person);
        }
        
        private static bool IsNotEligibleForDisability(Employee person)
        {
            return person.Seniority < 2 || person.MonthsDisabled > 12 || person.IsPartTime;
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