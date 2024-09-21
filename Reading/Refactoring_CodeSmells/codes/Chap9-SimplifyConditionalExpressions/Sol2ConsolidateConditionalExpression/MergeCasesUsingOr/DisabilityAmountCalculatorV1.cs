namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingOr
{
    internal class DisabilityAmountCalculatorV1
    {
        // example: 员工工伤费用
        internal double GetDisabilityAmount(Employee person)
        {
            double disabilityAmount = 0;
            if (person.Seniority < 2) return 0;
            if (person.MonthsDisabled > 12) return 0;  // Report in advance
            if (person.IsPartTime) return 0;

            //if (person.Seniority < 2 || person.MonthsDisabled > 12 || person.IsPartTime)
            //{
            //    return 0;
            //}

            // compute the disability amount
            return disabilityAmount;
        }
    }
}