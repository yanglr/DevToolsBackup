namespace SimplifyConditionalExpressions.Sol2ConsolidateConditionalExpression.MergeCasesUsingAnd
{
    internal class VacationCalculatorV1
    {
        internal static double ApplyVacation(Employee employee)
        {
            if (employee.OnVacation)
            {
                if (employee.ServiceYears > 10)
                {
                    return 1;
                }
            }

            return 0.5;
        }
    }
}